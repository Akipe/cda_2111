using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToutEmbalCore
{
    public class BoxProduction : IProducer
    {
        private static Random? _rnd = null;

        private int _productivityPerHour;
        private int _nbDone;
        private ProducerState _state;

        public event EventHandler OnMaxProduction;
        public event EventHandler OnStateChanged;


        private static Random GetRdn()
        {
            if (BoxProduction._rnd is null)
            {
                BoxProduction._rnd = new Random();
            }

            return BoxProduction._rnd;
        }

        public int RateDefectPercent
        {
            get; private set;
        }

        public int NbDone
        {
            get
            {
                return _nbDone;
            }
            
            private set
            {
                if (value > MaxWanted)
                {
                    throw new Exception(
                        "You can't create more box than the limit : " + MaxWanted.ToString()
                    );
                }

                _nbDone = value;
            }
        }

        public List<IProducerDefect> Defects
        {
            get; private set;
        }

        public int ProductivityPerHour
        {
            get
            {
                return _productivityPerHour;
            }

            set
            {
                _productivityPerHour = value;
                MilisecondsForOneProduct = 3600000 / value;
            }
        }

        public int MaxWanted
        {
            get; set;
        }

        public ProducerState State
        {
            get
            {
                return _state;
            }
            private set
            {
                _state = value;

                if (_state == ProducerState.started || _state == ProducerState.stopped)
                {
                    try
                    {
                        OnStateChanged.Invoke(this, new EventArgs());
                    }
                    catch (Exception e)
                    {
                        ExecuteOnStateChanged();
                    }
                }
                else
                {
                    ExecuteOnStateChanged();
                }
            }
        }

        public string Name
        {
            get; set;
        }

        public int MilisecondsForOneProduct
        {
            get; set;
        }

        public BoxProduction(
            string name,
            int productivityPerHour,
            int maxWanted,
            int rateDefectPercent
        )
        {
            if (rateDefectPercent < 0 && rateDefectPercent > 100)
            {
                throw new Exception(
                    "You have to set an rate defect between 0 and 100 (for a percent)"
                );
            }

            Name = name;
            ProductivityPerHour = productivityPerHour;
            MaxWanted = maxWanted;
            RateDefectPercent = rateDefectPercent;

            NbDone = 0;
            Defects = new List<IProducerDefect>();
            State = ProducerState.created;
        }

        public double GetTotalRateDefect()
        {
            if (NbDone == 0)
            {
                return 0.0;
            }

            return (double)Defects.Count / (double)NbDone;
        }

        public double GetLastHourRateDefect()
        {
            int countDefect = 0;
            TimeSpan oneHour = new TimeSpan(1, 0, 0);

            foreach (IProducerDefect defect in Defects)
            {
                var dateError = defect.GetWhenOccurred();
                var nowMinusOneHour = DateTime.Now - oneHour;
                if (defect.GetWhenOccurred() > (DateTime.Now - oneHour))
                {
                    countDefect++;
                }
            }

            return (double)countDefect / (double)ProductivityPerHour;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetProduction()
        {
            return NbDone;
        }

        public void Launch()
        {
            if (State != ProducerState.created)
            {
                return;
            }

            State = ProducerState.started;

            while (State != ProducerState.shutdown)
            {
                if (State == ProducerState.started)
                {
                    Thread.Sleep(MilisecondsForOneProduct);

                    if (IsBoxDefect())
                    {
                        Defects.Add(new ProduceDefect());
                    }

                    // If we keep defect product in production count,
                    // we don't remove it from the statistics
                    //else
                    //{
                    NbDone++;
                    //}

                    if (NbDone == MaxWanted)
                    {
                        State = ProducerState.shutdown;
                    }
                }
            }
        }

        public void Start()
        {
            if (
                State != ProducerState.shutdown &&
                State != ProducerState.created)
            {
                State = ProducerState.started;
            }
        }

        public void Stop()
        {
            if (
                State != ProducerState.shutdown &&
                State != ProducerState.created
            )
            {
                State = ProducerState.stopped;
            }
        }

        public void Shutdown()
        {
            if (State != ProducerState.created)
            {
                State = ProducerState.shutdown;
            }
        }

        private void ExecuteOnStateChanged()
        {
            if (OnStateChanged is not null)
            {
                OnStateChanged(this, new EventArgs());
            }
        }

        public void RunEventsOnStateChanged()
        {
            ExecuteOnStateChanged();
        }

        private bool IsBoxDefect()
        {
            int luck = BoxProduction.GetRdn().Next(0, 101);

            return RateDefectPercent > luck;
        }

        public int GetMilisecondsForCreateOne()
        {
            return MilisecondsForOneProduct;
        }

        public int GetNbWanted()
        {
            return MaxWanted;
        }

        public ProducerState GetState()
        {
            return State;
        }
    }
}
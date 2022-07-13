using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToutEmbalCore
{
    public class BoxProduction : IProducer
    {
        private int _productivityPerHour;
        private int _nbDone;

        public event EventHandler OnMaxProduction;
        public event EventHandler OnStateChanged;


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

                /*if (value == MaxWanted)
                {
                    if (OnMaxProduction is not null)
                    {
                        OnMaxProduction(this, new EventArgs());
                    }

                    Shutdown();
                }*/
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
            get; private set;
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
            OnStateChanged.Invoke(null, new EventArgs());
            //ExecuteOnStateChanged(); // todo: execute outside thread

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
                        OnStateChanged.Invoke(null, new EventArgs());
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
                ExecuteOnStateChanged();
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
                ExecuteOnStateChanged();
            }
        }

        public void Shutdown()
        {
            if (State != ProducerState.created)
            {
                State = ProducerState.shutdown;
                ExecuteOnStateChanged();
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
            Random rnd = new Random();
            int luck = rnd.Next(0, 101);

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
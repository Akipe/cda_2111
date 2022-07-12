using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToutEmbalCore
{
    public class BoxProduction : IProducer
    {
        private int _productivityPerHour;

        public event EventHandler OnMaxProduction;

        public int RateDefectPercent
        {
            get; private set;
        }

        public int NbDone
        {
            get; private set;
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
            State = ProducerState.stopped;
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

        public void Start()
        {
            if (State != ProducerState.stopped)
            {
                return;
            }

            State = ProducerState.started;

            while (State == ProducerState.started)
            {
                Thread.Sleep(MilisecondsForOneProduct);

                if (IsBoxDefect())
                {
                    Defects.Add(new ProduceDefect());
                }
                //else
                //{
                NbDone++;
                //}

                if (NbDone == MaxWanted)
                {
                    if (OnMaxProduction is not null)
                    {
                        OnMaxProduction(this, new EventArgs());
                    }

                    Shutdown();
                }
            }
        }

        public void Stop()
        {
            State = ProducerState.stopped;
        }

        public void Shutdown()
        {
            State = ProducerState.shutdown;
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
    }
}
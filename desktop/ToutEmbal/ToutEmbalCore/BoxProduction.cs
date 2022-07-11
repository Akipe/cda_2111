using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToutEmbalCore
{
    public class BoxProduction : IProducer
    {
        private const int MIN_RANDOM_DEFECT = 100;
        private const int MAX_RANDOM_DEFECT = 1000;
        private const int MAKE_DEFECT = 1;

        private long _productivityPerHour;
        private int _defectCounter;

        public long NbDone
        {
            get; private set;
        }

        public List<IProducerDefect> Defects
        {
            get; private set;
        }

        public long ProductivityPerHour
        {
            get
            {
                return _productivityPerHour;
            }

            set
            {
                _productivityPerHour = value;
                MilisecondsForOneProduct = 3600000 / (int)value;
            }
        }

        public long? MaxWanted
        {
            get; set;
        }

        public ProducerState State
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        private int DefectCounter
        {
            get
            {
                if (_defectCounter > 1)
                {
                    return --_defectCounter;
                }

                _defectCounter = GenerateRandomDefectCounter();

                return _defectCounter;
            }
            set
            {
                _defectCounter = value;
            }
        }

        private int GenerateRandomDefectCounter()
        {
            Random rnd = new Random();
            return rnd.Next(MIN_RANDOM_DEFECT, MAX_RANDOM_DEFECT);
        }

        public int MilisecondsForOneProduct
        {
            get; set;
        }

        public BoxProduction(
            string name,
            long productivityPerHour,
            long? maxWanted
        )
        {
            Name = name;
            ProductivityPerHour = productivityPerHour;
            MaxWanted = maxWanted;

            NbDone = 0;
            DefectCounter = GenerateRandomDefectCounter();
            Defects = new List<IProducerDefect>();
            State = ProducerState.stopped;
        }

        public BoxProduction(
            string name,
            long productivityPerHour
        ) : this(name, productivityPerHour, null)
        {
        }

        public double GetTotalRateDefect()
        {
            return Defects.Count;
        }

        public double GetLastHourRateDefect()
        {
            int countDefect = 0;
            TimeSpan oneHour = new TimeSpan(1, 0, 0);

            foreach (IProducerDefect defect in Defects)
            {
                if (defect.GetWhenOccurred() > DateTime.Now - oneHour)
                {
                    countDefect++;
                }
            }

            return countDefect;
        }

        public string GetName()
        {
            return Name;
        }

        public long GetProduction()
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

                if (DefectCounter == MAKE_DEFECT)
                {
                    Defects.Add(new ProduceDefect());
                }
                else
                {
                    NbDone++;
                }
            }
        }

        public void Stop()
        {
            State = ProducerState.stopped;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToutEmbalCore.Producers
{
    public class ProducerDefectManager : IProducerDefectManager
    {
        private double _defectRate;

        private IProducer Producer { get; init; }
        private double DefectRate
        {
            get
            {
                return _defectRate;
            }
            init
            {
                _defectRate = Producer.GetMilisecondsForCreateOne();
            }
        }

        public ProducerDefectManager(IProducer producer)
        {
            Producer = producer;
        }

        public double GetLastHourDefectRate()
        {
            throw new NotImplementedException();
        }

        public double GetTotalDefectRate()
        {
            throw new NotImplementedException();
        }

        public bool IsDefect()
        {
            throw new NotImplementedException();
        }
    }
}

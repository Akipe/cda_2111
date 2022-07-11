using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToutEmbalCore
{
    public class ProducerManager
    {
        public List<IProducer> Producers
        {
            get;
            private set;
        }

        public ProducerManager()
        {
            Producers = new List<IProducer>();
        }

        public void Add(IProducer boxProduction)
        {
            Producers.Add(boxProduction);
        }

        public void Stop(string name)
        {
            GetProducerFromName(name).Stop();
        }

        public void Start(string name)
        {
            GetProducerFromName(name).Start();
        }

        private IProducer GetProducerFromName(string name)
        {
            foreach (IProducer boxProduction in Producers)
            {
                if (String.Equals(boxProduction.GetName(), name))
                {
                    return boxProduction;
                }
            }

            throw new ArgumentException("There is no elements found.");
        }
    }
}
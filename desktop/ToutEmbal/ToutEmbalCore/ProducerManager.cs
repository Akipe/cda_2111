using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToutEmbalCore
{
    public class ProducerManager
    {
        public IProducer Unit
        {
            get;
            private set;
        }

        public Thread Runner
        {
            get;
            private set;
        }

        public ProducerManager(IProducer unit)
        {
            Unit = unit;

            Runner = new Thread(() =>
            {
                Unit.Start();
            });
        }

        public void Start()
        {
            Runner.Start();
        }

        public void Stop()
        {
            Unit.Stop();
        }

        public void Shutdown()
        {
            Unit.Shutdown();
        }
    }
}
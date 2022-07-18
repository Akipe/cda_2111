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

        public Thread? Runner
        {
            get;
            private set;
        }

        public ProducerManager(IProducer unit)
        {
            Unit = unit;

            Runner = null;
        }

        public void Launch()
        {
            if (Runner is null)
            {

                Runner = new Thread(() =>
                {
                    Unit.Launch();
                });
                Runner.Start();
            }
        }

        public void Stop()
        {
            Unit.Stop();
        }

        public void Start()
        {
            Unit.Start();
        }

        public void Shutdown()
        {
            Unit.Shutdown();
        }

        public override string ToString()
        {
            return Unit.GetName();
        }
    }
}
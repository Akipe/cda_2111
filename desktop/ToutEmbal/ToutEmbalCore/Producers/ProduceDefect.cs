using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToutEmbalCore.Producers
{
    public class ProduceDefect : IProducerDefect
    {
        public DateTime WhenOccured
        {
            get;
            init;
        }

        public ProduceDefect()
        {
            WhenOccured = DateTime.Now;
        }
        public DateTime GetWhenOccurred()
        {
            return WhenOccured;
        }
    }
}

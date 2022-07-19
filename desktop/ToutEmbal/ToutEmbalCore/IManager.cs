using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToutEmbalCore
{
    public interface IManager
    {
        IProducer GetUnit();
        void Launch();
        void Stop();
        void Start();
        void Shutdown();
        string ToString();
    }
}

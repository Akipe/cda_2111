using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToutEmbalCore
{
    public interface IProducer
    {
        void Start();
        void Stop();
        long GetProduction();
        double GetLastHourRateDefect();
        double GetTotalRateDefect();
        string GetName();
    }
}
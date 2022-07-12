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
        void Shutdown();
        int GetProduction();
        double GetLastHourRateDefect();
        double GetTotalRateDefect();
        string GetName();
        int GetMilisecondsForCreateOne();
        int GetNbWanted();
        public event EventHandler OnMaxProduction;
    }
}
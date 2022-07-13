using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToutEmbalCore
{
    public interface IProducer
    {
        void Launch();
        void Stop();
        void Start();
        void Shutdown();
        ProducerState GetState();
        int GetProduction();
        double GetLastHourRateDefect();
        double GetTotalRateDefect();
        string GetName();
        int GetMilisecondsForCreateOne();
        int GetNbWanted();
        void RunEventsOnStateChanged();
        public event EventHandler OnMaxProduction;
        public event EventHandler OnStateChanged;
    }
}
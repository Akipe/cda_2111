using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToutEmbalCore.Producers;

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
        event EventHandler OnMaxProduction;
        event EventHandler OnStateChanged;
        event EventHandler OnCreateOne;
    }
}
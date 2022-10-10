using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToutEmbalCore
{
    public interface IProducerDefectManager
    {
        //void SetDefectRate(int productivityPerHour);
        bool IsDefect();
        double GetTotalDefectRate();
        double GetLastHourDefectRate();
    }
}

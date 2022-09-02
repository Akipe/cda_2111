using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkpMatrix.UI
{
    public interface IMemento
    {
        DateTime GetQuandCree();
        string GetDescription();
        string GetSerialisation();
    }
}

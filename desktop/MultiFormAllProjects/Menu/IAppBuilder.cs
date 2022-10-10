using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    public interface IAppBuilder
    {
        public Form CreateInstance();
    }
}

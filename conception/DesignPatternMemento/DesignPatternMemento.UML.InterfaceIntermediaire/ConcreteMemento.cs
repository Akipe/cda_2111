using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMemento.UML.InterfaceIntermediaire
{
    internal class ConcreteMemento : IMemento
    {
        public ConcreteMemento(string state)
        {
            throw new System.NotImplementedException();
        }

        public string state
        {
            get => default;
            set
            {
            }
        }

        public string GetState()
        {
            throw new System.NotImplementedException();
        }
    }
}

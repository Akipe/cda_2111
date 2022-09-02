using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMemento.UML.InterfaceIntermediaire
{
    internal class Originator
    {
        public string state
        {
            get => default;
            set
            {
            }
        }

        public ConcreteMemento save()
        {
            throw new System.NotImplementedException();
        }

        public void restore(ConcreteMemento objetSave)
        {
            throw new System.NotImplementedException();
        }
    }
}

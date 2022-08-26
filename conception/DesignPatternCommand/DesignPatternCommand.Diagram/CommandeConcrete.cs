using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCommand.Diagram
{
    internal class CommandeConcrete : ICommande
    {
        internal Recepteur Recepteur
        {
            get => default;
            set
            {
            }
        }

        public void Annuler()
        {
            throw new System.NotImplementedException();
        }

        public void Executer()
        {
            throw new System.NotImplementedException();
        }
    }
}

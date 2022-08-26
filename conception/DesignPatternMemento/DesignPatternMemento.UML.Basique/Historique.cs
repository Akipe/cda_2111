using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMemento.UML.Basique
{
    public class Historique
    {
        public List<EditeurSnapshot> List { get; set; }

        public Historique()
        {
            List = new List<EditeurSnapshot>();
        }
    }
}

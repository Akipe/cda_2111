using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMemento.UML.Basique
{
    public class Gardien
    {
        public Historique Historique
        {
            get; init;
        }

        public Commande Commande
        {
            get; init;
        }

        public Gardien()
        {
            Historique = new Historique();
            Commande = new Commande();
        }
    }
}

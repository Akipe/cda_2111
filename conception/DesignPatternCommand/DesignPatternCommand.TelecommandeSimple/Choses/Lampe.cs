using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCommand.TelecommandeSimple.Choses
{
    public class Lampe
    {
        private bool _estAllume;

        public Lampe()
        {
            _estAllume = false;
        }

        public void Marche()
        {
            _estAllume = true;
        }

        public void Arret()
        {
            _estAllume = false;
        }

        public string Etat()
        {
            if (_estAllume)
            {
                return "Lampe allumé";
            }

            return "Lampe éteint";
        }
    }
}

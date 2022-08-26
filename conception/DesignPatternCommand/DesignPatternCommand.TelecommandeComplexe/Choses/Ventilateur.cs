using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCommand.TelecommandeComplexe.Choses
{
    public class Ventilateur
    {
        private VentilateurVitesse _vitesse;

        public Ventilateur()
        {
            _vitesse = VentilateurVitesse.Arret;
        }

        public void Arret()
        {
            _vitesse = VentilateurVitesse.Arret;
        }

        public void VitesseLent()
        {
            _vitesse = VentilateurVitesse.Lent;
        }

        public void VitesseMoyen()
        {
            _vitesse = VentilateurVitesse.Moyen;
        }

        public void VitesseRapide()
        {
            _vitesse = VentilateurVitesse.Rapide;
        }

        public VentilateurVitesse GetVitesse()
        {
            return _vitesse;
        }
    }
}

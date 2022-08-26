using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCommand.TelecommandeComplexe.Choses
{
    public class PorteGarage
    {
        private bool _estFerme;
        private bool _lampeAllume;

        public PorteGarage()
        {
            _estFerme = true;
            _lampeAllume = false;
        }

        public void Ouvrir()
        {
            _estFerme = false;
        }

        public void Fermer()
        {
            _estFerme = true;
        }

        public void Stop()
        {

        }

        public void LampeAllumee()
        {
            _lampeAllume = true;
        }

        public void LampeEteinte()
        {
            _lampeAllume = false;
        }

        public string statusFerme()
        {
            if (_estFerme)
            {
                return "Le garage est fermé";
            }

            return "Le garage n'est pas fermé";
        }

        public string statusLampe()
        {
            if (_lampeAllume)
            {
                return "La lampe du garage est allumée";
            }

            return "La lampe du garage est éteinte";
        }
    }
}

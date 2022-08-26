using DesignPatternCommand.TelecommandeComplexe.Choses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCommand.TelecommandeComplexe.Commandes
{
    public class CommandeEteindreStereo : ICommande
    {
        private StereoAvecCD _stereo;

        public CommandeEteindreStereo(StereoAvecCD stereo)
        {
            _stereo = stereo;
        }

        public void Annuler()
        {
            _stereo.Allumer();
            _stereo.MettreCD();
            _stereo.DefinirVolume(5);
        }

        public void Executer()
        {
            _stereo.Eteindre();
        }
    }
}

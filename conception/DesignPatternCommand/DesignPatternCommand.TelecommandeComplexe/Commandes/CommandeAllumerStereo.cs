using DesignPatternCommand.TelecommandeComplexe.Choses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCommand.TelecommandeComplexe.Commandes
{
    public class CommandeAllumerStereo : ICommande
    {
        private StereoAvecCD _stereo;

        public CommandeAllumerStereo(StereoAvecCD stereo)
        {
            _stereo = stereo;
        }

        public void Annuler()
        {
            _stereo.Eteindre();
        }

        public void Executer()
        {
            _stereo.Allumer();
            _stereo.MettreCD();
            _stereo.DefinirVolume(5);
        }
    }
}

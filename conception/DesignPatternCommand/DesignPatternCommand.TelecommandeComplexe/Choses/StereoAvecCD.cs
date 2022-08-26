using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCommand.TelecommandeComplexe.Choses
{
    public class StereoAvecCD
    {
        private bool _isStarted;
        private bool _isCDSet;
        private int _volume;

        public StereoAvecCD()
        {
            _isStarted = false;
            _isCDSet = false;
            _volume = 0;
        }

        public void Allumer()
        {
            _isStarted = true;
        }

        public void Eteindre()
        {
            _isStarted = false;
        }

        public void MettreCD()
        {
            _isCDSet = true;
        }

        public void DefinirVolume(int niveau)
        {
            if (niveau < 0 && niveau > 10)
            {
                throw new ArgumentException("Le volume peut être entre 0 et 10");
            }

            _volume = niveau;
        }
    }
}

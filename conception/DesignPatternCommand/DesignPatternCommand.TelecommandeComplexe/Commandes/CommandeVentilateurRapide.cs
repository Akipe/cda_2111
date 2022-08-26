using DesignPatternCommand.TelecommandeComplexe.Choses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCommand.TelecommandeComplexe.Commandes
{
    public class CommandeVentilateurRapide : ICommande
    {
        private Ventilateur _ventilateur;
        private VentilateurVitesse _vitessePrecedante;

        public CommandeVentilateurRapide(Ventilateur ventilateur)
        {
            _ventilateur = ventilateur;
            _vitessePrecedante = ventilateur.GetVitesse();
        }

        public void Executer()
        {
            _vitessePrecedante = _ventilateur.GetVitesse();
            _ventilateur.VitesseRapide();
        }

        /// <summary>
        /// Pour implémenter l'annulation,
        /// on doit sauvegarder l'état précédent de la vitesse,
        /// qui peut avoir 4 choix.
        /// </summary>
        public void Annuler()
        {
            switch(_vitessePrecedante)
            {
                case VentilateurVitesse.Arret:
                    _ventilateur.Arret();
                    break;
                case VentilateurVitesse.Lent:
                    _ventilateur.VitesseLent();
                    break;
                case VentilateurVitesse.Moyen:
                    _ventilateur.VitesseMoyen();
                    break;
                case VentilateurVitesse.Rapide:
                    _ventilateur.VitesseRapide();
                    break;
            }
        }
    }
}

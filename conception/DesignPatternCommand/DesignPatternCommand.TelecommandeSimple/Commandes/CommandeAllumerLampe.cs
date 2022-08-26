using DesignPatternCommand.TelecommandeSimple;
using DesignPatternCommand.TelecommandeSimple.Choses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCommand.TelecommandeSimple.Commandes
{
    public class CommandeAllumerLampe : ICommande
    {
        // Référence à l'objet sur lequel on execute les actions
        private readonly Lampe _lampe;

        public CommandeAllumerLampe(Lampe lampe)
        {
            _lampe = lampe;
        }

        public void Executer()
        {
            _lampe.Marche();
        }
    }
}

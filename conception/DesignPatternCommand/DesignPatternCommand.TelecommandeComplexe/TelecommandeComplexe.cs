using DesignPatternCommand.TelecommandeComplexe.Commandes;
using System.Text;

namespace DesignPatternCommand.TelecommandeComplexe
{
    public class TelecommandeComplexe
    {
        public const int NOMBRE_MAX_COMMANDES = 7;

        private ICommande[] commandesMarche;
        private ICommande[] commandesArret;
        private ICommande derniereCommande;

        public TelecommandeComplexe()
        {
            commandesMarche = new ICommande[NOMBRE_MAX_COMMANDES];
            commandesArret = new ICommande[NOMBRE_MAX_COMMANDES];

            ICommande aucuneCommande = new AucuneCommande();

            for (int index = 0; index < NOMBRE_MAX_COMMANDES; index++)
            {
                commandesMarche[index] = aucuneCommande;
                commandesArret[index] = aucuneCommande;
            }

            derniereCommande = aucuneCommande;
        }

        public void SetCommande(
            int emplacement,
            ICommande cmdMarche,
            ICommande cmdArret
        )
        {
            if (emplacement < 1 || emplacement > NOMBRE_MAX_COMMANDES)
            {
                throw new ArgumentException(
                    $"L'emplacement doit être entre 1 et {NOMBRE_MAX_COMMANDES}."
                );
            }

            --emplacement;

            commandesMarche[emplacement] = cmdMarche;
            commandesArret[emplacement] = cmdArret;
        }

        public void ActionnerBoutonMarche(int emplacement)
        {
            --emplacement;
            commandesMarche[emplacement].Executer();
            derniereCommande = commandesMarche[emplacement];
        }

        public void ActionnerBoutonEteindre(int emplacement)
        {
            --emplacement;
            commandesArret[emplacement].Executer();
            derniereCommande = commandesMarche[emplacement];
        }

        public void AnnulerDerniereAction()
        {
            derniereCommande.Annuler();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append("\n------ Télécommande -------\n");
            for (int index = 0; index < NOMBRE_MAX_COMMANDES; index++)
            {
                output.Append("Emplacement ");
                output.Append(index + 1);
                output.Append(" : ");
                output.Append(commandesMarche[index].GetType().Name);
                output.Append(" & ");
                output.Append(commandesArret[index].GetType().Name);
                output.Append("\n");
            }

            return output.ToString();
        }
    }
}
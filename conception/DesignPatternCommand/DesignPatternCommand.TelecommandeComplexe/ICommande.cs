namespace DesignPatternCommand.TelecommandeComplexe
{
    /// <summary>
    /// Tous les objets commandes implémente cette interface
    /// </summary>
    public interface ICommande
    {
        /// <summary>
        /// Similaire à la methode "faireMarcher()" de la caféteria
        /// </summary>
        void Executer();

        /// <summary>
        /// Permet d'annuler l'action de la methode "Executer()";
        /// </summary>
        void Annuler();
    }
}
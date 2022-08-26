namespace DesignPatternCommand.TelecommandeSimple
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
    }
}
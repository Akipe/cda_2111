namespace DesignPatternMemento.UML.Basique
{
    public class Editeur
    {
        public string Contenu { get; set; }
        public string StyleSelectionne { get; set; }

        public Editeur()
        {
            Contenu = String.Empty;
            StyleSelectionne = "Arial";
        }

        public EditeurSnapshot FaireSnapshot()
        {
            return new EditeurSnapshot(
                contenu: Contenu,
                styleSelectionne: StyleSelectionne
            );
        }

        public void RestaurerSnapshot(EditeurSnapshot snapshot)
        {
            Contenu = snapshot.Contenu;
            StyleSelectionne = snapshot.StyleSelectionne;
        }
    }
}
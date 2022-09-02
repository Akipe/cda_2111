namespace DesignPatternMemento.UML.AvecCommande
{
    public class Editeur
    {
        private string _contenu;

        public string Contenu
        {
            get
            {
                return _contenu;
            }
            set
            {
                _contenu = value;
                TempsDerniereEdition = DateTime.Now;
            }
        }

        public DateTime TempsDerniereEdition { get; private set; }

        public Editeur()
        {
            Contenu = String.Empty;
            TempsDerniereEdition = DateTime.Now;
        }

        public Instantane CreerInstantane()
        {
            return new Instantane(
                this,
                Contenu,
                TempsDerniereEdition
            );
        }

        public void Restaurer(Instantane instantane)
        {
            Contenu = instantane.contenu;
            TempsDerniereEdition = instantane.tempsDerniereEdition;
        }
    }
}
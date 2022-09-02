namespace PresentationCommande
{
    public partial class EditeurTexte : Form
    {
        private ZoneSaisie zoneSaisie;
        private Fichier fichier;

        public EditeurTexte()
        {
            InitializeComponent();

            tbTaillePolice.Value = (int)zoneSaisie.Font.Size;

            fichier = new Fichier("C:/chemin/fichier.txt");

            KeyPreview = true;
        }

        private void QuandCliqueGras(object sender, EventArgs e)
        {
            zoneSaisie.MettreEnGras();
        }

        private void QuandCliqueItalique(object sender, EventArgs e)
        {
            zoneSaisie.MettreEnItalique();
        }

        private void QuandDefinirTaillePolice(object sender, EventArgs e)
        {
            zoneSaisie.ChangerTaillePolice(
                (int)tbTaillePolice.Value
            );
        }

        private void CliqueCharger(object sender, EventArgs e)
        {
            zoneSaisie.Text = fichier.Charger();
        }

        private void CliqueSauvegarder(object sender, EventArgs e)
        {
            fichier.Sauvegarder(zoneSaisie.Text);
        }

        private void QuandAppuyeSurClavier(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.G)
                zoneSaisie.MettreEnGras();

            if (e.Control && e.KeyCode == Keys.I)
                zoneSaisie.MettreEnItalique();

            if (e.Control && e.KeyCode == Keys.P)
                zoneSaisie.ChangerTaillePolice(
                    (int) zoneSaisie.Font.Size + 1
                );

            if (e.Control && e.KeyCode == Keys.M)
                zoneSaisie.ChangerTaillePolice(
                    (int)zoneSaisie.Font.Size - 1
                );

            if (e.Control && e.KeyCode == Keys.S)
                fichier.Sauvegarder(zoneSaisie.Text);
        }
    }
}
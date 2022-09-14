namespace MementoUI
{
    public partial class UI : Form
    {
        private Personnage perso;
        private List<InstantanePersonnage> instantanesPerso;

        public UI()
        {
            InitializeComponent();

            perso = new Personnage();

            perso.AugmenterAttaque();
            perso.AugmenterAttaque();
            perso.AugmenterDefense();
            perso.AugmenterDefense();
            perso.AugmenterDefense();
            perso.AugmenterDefense();

            lDefenseValeur.Text = perso.GetDefense().ToString();
            lAttaqueValeur.Text = perso.GetAttaque().ToString();
            lChanceValeur.Text = perso.GetChance().ToString();

            instantanesPerso = new List<InstantanePersonnage>();
            //cbInstantaneSelectionne.DataSource = instantanesPerso;
            //cbInstantaneSelectionne.DisplayMember = "creation"; 
        }

        private void bAugmenterDefense_Click(object sender, EventArgs e)
        {
            perso.AugmenterDefense();
            lDefenseValeur.Text = perso.GetDefense().ToString();
            lChanceValeur.Text = perso.GetChance().ToString();
        }

        private void bAugmenterAttaque_Click(object sender, EventArgs e)
        {
            perso.AugmenterAttaque();
            lAttaqueValeur.Text = perso.GetAttaque().ToString();
        }

        private void bSauvegarder_Click(object sender, EventArgs e)
        {
            /*instantanesPerso.Add(perso.CreerInstantane());
            instantanesPersoIndex.Add((++dernierIndex).ToString());
            cbInstantaneSelectionne.DataSource = instantanesPersoIndex*/
            instantanesPerso.Add(perso.CreerInstantane());
            cbInstantane.Items.Add(DateTime.Now.ToLongTimeString());
        }

        private void bRestaurer_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(cbInstantane.SelectedIndex);
            perso.RestaurerInstantane(
                instantanesPerso[index]
            );
            lAttaqueValeur.Text = perso.GetAttaque().ToString();
            lDefenseValeur.Text = perso.GetDefense().ToString();
            lChanceValeur.Text = perso.GetChance().ToString();
        }

        private void cbInstantaneSelectionne_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
using TreeViewCore;
using TreeViewCore.node;

namespace TreeViewUI
{
    public partial class MainForm : Form
    {
        private NodeGeneratorUI Generator;
        private LogUI Log;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Generator = new NodeGeneratorUI(tvNodeTree);
            Log = new LogUI(tsslSearchStatus);
        }

        private void bShowDiskRoot_Click(object sender, EventArgs e)
        {
            Generator.GenerateRoot(@"C:\");
        }

        private void tbRootPath_Leave(object sender, EventArgs e)
        {
            try
            {
                Log.Msg($"Recherche dans {tbRootPath.Text}");
                Generator.GenerateRoot(tbRootPath.Text);
            }
            catch(ArgumentException)
            {
                Log.Msg($"Le chemin {tbRootPath.Text} n'existe pas");
                MessageBox.Show(
                    "Veuillez définir un dossier existant",
                    "Erreur de chemin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void bOpenBranch_Click(object sender, EventArgs e)
        {
            Generator.ExpandsAllNodes();
        }

        private void bCloseBranch_Click(object sender, EventArgs e)
        {
            Generator.CollapseAllNodes();
        }
    }
}
using TreeViewCore;
using TreeViewCore.node;

namespace TreeViewUI
{
    public partial class MainForm : Form
    {
        private NodeGeneratorUI UiGenerator;
        private LogUI Log;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UiGenerator = new NodeGeneratorUI(tvNodeTree);
            Log = new LogUI(this, tsslSearchStatus);
            TriggerCollapseExpandsBtn(false);
        }

        private void bShowDiskRoot_Click(object sender, EventArgs e)
        {
            Log.Msg($"Recherche dans C:\\");

            Thread seekThread = new Thread(() => GenerateTreeNode(@"C:\"));
            seekThread.Start();
        }

        private void tbRootPath_Leave(object sender, EventArgs e)
        {
                Log.Msg($"Recherche dans {tbRootPath.Text}");

                Thread seekThread = new Thread(() => GenerateTreeNode(tbRootPath.Text));
                seekThread.Start();
        }

        private void GenerateTreeNode(string path)
        {
            try
            {
                NodeGenerator.SetRoot(path);
                Dir root = NodeGenerator.Root;

                this.Invoke(new MethodInvoker(() => {
                    UiGenerator.Generate(root);
                    TriggerCollapseExpandsBtn(true);
                }));
            }
            catch (ArgumentException)
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    TriggerCollapseExpandsBtn(false);
                    Log.Msg($"Le chemin {tbRootPath.Text} n'existe pas");
                    MessageBox.Show(
                        "Veuillez définir un dossier existant",
                        "Erreur de chemin",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }));
            }
        }

        private void bOpenBranch_Click(object sender, EventArgs e)
        {
            UiGenerator.ExpandsAllNodes();
        }

        private void bCloseBranch_Click(object sender, EventArgs e)
        {
            UiGenerator.CollapseAllNodes();
        }

        private void TriggerCollapseExpandsBtn(Boolean status)
        {
            bCloseBranch.Enabled = status;
            bOpenBranch.Enabled = status;
        }
    }
}
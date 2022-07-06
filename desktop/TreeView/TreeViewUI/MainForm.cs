using TreeViewCore;
using TreeViewCore.node;

namespace TreeViewUI
{
    public partial class MainForm : Form
    {
        private LogUI Log;
        private NodeTreeUI nodeTreeUI;
        string? rootPath;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Log = new LogUI(this, tsslSearchStatus);
            nodeTreeUI = new NodeTreeUI(
                tvNodeTree,
                bCloseBranch,
                bOpenBranch
            );
            rootPath = null;

            bShowDiskRoot.Tag = @"C:\";

            Log.Msg($"Veuillez entrer un chemin");
        }

        private void SearchFiles_Execute(object sender, EventArgs e)
        {
            string path = "";

            if (sender is Button btn)
            {
                if (btn.Tag is string btnPath)
                {
                    rootPath = btnPath;
                }
            }
            if (sender is TextBox tb)
            {
                rootPath = tb.Text;
            }

            Log.Msg($"Recherche dans {rootPath}");

            Thread seekThread = new Thread(() =>
            {
                GenerateTreeNode(rootPath);
            }
            );
            seekThread.Start();
        }

        private void GenerateTreeNode(string path)
        {
            try
            {
                NodeGenerator.SetRoot(path);
                Dir root = NodeGenerator.Root;

                List<TreeNode> rootNodes = NodeTreeUIGenerator.Generate(root);

                this.Invoke(new MethodInvoker(() => {
                        nodeTreeUI.SetRootNode(rootNodes[0]);
                }));
            }
            catch (ArgumentException)
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    GenerateNotFound();
                }));
            }
        }

        private void GenerateNotFound()
        {
            nodeTreeUI.Clear();

            Log.Msg($"Le chemin {rootPath} n'existe pas");

            MessageBox.Show(
                $"Le dossier \"${rootPath}\" n'existe pas.",
                "Chemin de dossier inconnu",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        private void bOpenBranch_Click(object sender, EventArgs e)
        {
            nodeTreeUI.ExpandsAllNodes();
        }

        private void bCloseBranch_Click(object sender, EventArgs e)
        {
            nodeTreeUI.CollapseAllNodes();
        }
    }
}
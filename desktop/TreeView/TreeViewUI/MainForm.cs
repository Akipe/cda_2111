using TreeViewCore;
using TreeViewCore.node;

namespace TreeViewUI
{
    public partial class MainForm : Form
    {
        private LogUI Log;
        private NodeTreeUI nodeTreeUI;
        string? rootPath;
        private int logSearchCount;

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
            logSearchCount = 1;

            bShowDiskRoot.Tag = @"C:\";

            seekLoad.Tick += new EventHandler(UpdateMsgSearch);
            seekLoad.Interval = 1000;

            Log.Msg($"Veuillez entrer un chemin");
        }

        private void SearchFiles_Execute(object sender, EventArgs e)
        {
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

            ExecuteSearch(rootPath);
        }

        private void ExecuteSearch(string path)
        {
            Log.Msg($"Recherche dans {path}");

            seekLoad.Enabled = true;
            seekLoad.Start();

            Thread seekThread = new Thread(() =>
            {
                GenerateTreeNode(path);
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
                        seekLoad.Stop();

                        Log.Msg($"Recherche terminé.");
                }));
            }
            catch (ArgumentException)
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    seekLoad.Stop();
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

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                rootPath = folderBrowser.SelectedPath;
                tbRootPath.Text = rootPath;

                ExecuteSearch(rootPath);
            }
        }

        private void UpdateMsgSearch(object? sender, EventArgs e)
        {
            if (logSearchCount > 3)
            {
                logSearchCount = 1;
            }
            Log.Msg($"Recherche {rootPath} en cours " + new String('.', logSearchCount++));
        }
    }
}
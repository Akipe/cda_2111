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
        private Thread? seekThread;
        private CancellationTokenSource seekThreadCts;

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

            seekThread = null;
            seekThreadCts = new CancellationTokenSource();

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

            if (seekThread is not null)
            {
                DialogResult response = MessageBox.Show(
                    "Êtes-vous sûr de stopper la recherche actuelle ?",
                    "Nouvelle recherche",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (response != DialogResult.Yes)
                {
                    return;
                }

                seekThreadCts.Cancel();
                seekThreadCts.Dispose();
            }

            seekThread = new Thread(() =>
            {
                seekThreadCts = new CancellationTokenSource();
                GenerateTreeNode(path, seekThreadCts.Token);
            }
            );
            seekThread.Start();
        }

        private void GenerateTreeNode(string path, CancellationToken cancellationToken)
        {
            try
            {
                Dir root = NodeGenerator.Generate(path, cancellationToken);
                List<TreeNode> rootNodes = NodeTreeUIGenerator.Generate(root, cancellationToken);
                
                string msgCountNodes = $"{NodeTreeUIGenerator.Count}";

                string s = "";
                if (NodeTreeUIGenerator.Count > 0)
                {
                    s = "s";
                }

                this.Invoke(new MethodInvoker(() => {
                    nodeTreeUI.SetRootNode(rootNodes[0]);
                    seekLoad.Stop();

                    seekThread = null;

                    Log.Msg($"Recherche terminé : élément{s} trouvé{s}");
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
            catch (OperationCanceledException)
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    seekLoad.Stop();
                }));
            }
            finally
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    seekThread = null;
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
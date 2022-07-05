using _02_simple_addition;

namespace Menu
{
    public partial class frmMenu : Form
    {
        private Authentification authManager { get; set; }
        private ToolStripItemCollection Stage3 { get; set; }
        private List<Form> LaunchedApp { get; set; }

        #region Constructor

        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            ToggleBtn(false);

            authManager = Authentification.GetIteration();
            authManager.OnConnected += EnableBtn;
            authManager.OnLogout += DisableBtn;

            tslAuth.Tag = false;

            tsslDateNow.Text = DateTime.Now.ToString("MM/dd/yyyy");

            miSumMaker.Tag = typeof(AppBuilder<>).MakeGenericType(new SimpleAdditionForm().GetType());
        }

        #endregion Constructor

        #region Events

        private void EnableBtn(object sender, EventArgs e)
        {
            ToggleBtn(true);
        }

        private void DisableBtn(object sender, EventArgs e)
        {
            ToggleBtn(false);
        }

        private void ConnectionLogin_Click(object sender, EventArgs e)
        {
            if (!authManager.IsConnected)
            {
                authManager.Connect();
                MessageBox.Show(
                    "Bienvenue",
                    "Connexion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void ConnectionLogout_Click(object sender, EventArgs e)
        {
            if (authManager.IsConnected)
            {
                DialogResult choice = MessageBox.Show(
                    "Quitter l'application ?",
                    "Quitter ?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (choice == DialogResult.Yes)
                {
                    authManager.Logout();
                    Application.Exit();
                }
            }
        }

        private void tslAuth_Click(object sender, EventArgs e)
        {
            if ((bool)tslAuth.Tag)
            {
                ConnectionLogout_Click(sender, e);
            }
            else
            {
                ConnectionLogin_Click(sender, e);
            }
        }

        #endregion Event

        #region Helper

        private void ToggleBtn(Boolean status)
        {
            tsmiStage1.Enabled = status;
            tsmiStage2.Enabled = status;
            tsmiStage3.Enabled = status;
            tsmiStageWindows.Enabled = status;
            tsddbStage3.Enabled = status;

            SetLastActionLog(status ?
                "Connecté" : "Deconnecté"
            );
            tslAuth.Tag = status;
            tslAuth.Text =
                status ? "Se deconnecter" : "S'identifier";
        }

        private void SetLastActionLog(string message)
        {
            tsslLastAction.Text = message;
        }

        #endregion Helper

        private void sytnhèseToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StartChildrenForm_Click(object sender, EventArgs e)
        {
            //_02_simple_addition.SimpleAdditionForm monObj = new _02_simple_addition.SimpleAdditionForm();
/*            string test = typeof(SimpleAdditionForm).AssemblyQualifiedName;
*/
            if (sender is ToolStripItem item)
            {
                var typeBuilderApp = (Type)item.Tag;


                //string test = item.Tag.ToString();
                //string test = "_02_simple_addition.SimpleAdditionForm";
                //Type formType = Type.GetType(test);

                Type formBuilderType = typeof(AppBuilder<>).MakeGenericType(new SimpleAdditionForm().GetType());

                var instanceBuilder = Activator.CreateInstance(formBuilderType);

                /*if (formType != null)
                {
                    object objectForm = (Form)Activator.CreateInstance(formType);

                    if (objectForm is Form childrenForm)
                    {
                        List<Form> alreadyLaunched = 
                            LaunchedApp.FindAll(
                                f => f.GetType() == formType
                            );
                        childrenForm.MaximizeBox = false;
                        childrenForm.MinimizeBox = false;
                        childrenForm.WindowState = FormWindowState.Maximized;
                        childrenForm.FormClosing += App_Closing;
                        childrenForm.MdiParent = this;
                        childrenForm.Show();
                    }

                }*/
            }
        }

        private void App_Closing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Toto");
        }
    }
}
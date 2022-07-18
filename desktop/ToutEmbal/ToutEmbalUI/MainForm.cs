using ToutEmbalCore;

namespace ToutEmbalUI
{
    public partial class MainForm : Form
    {
        List<ProducerManagerUI> prodManagersUI;
        List<ProducerManager> prodManagers;

        ProducerManager ManagerA { get; init; }
        ProducerManager ManagerB { get; init; }
        ProducerManager ManagerC { get; init; }

        public MainForm()
        {
            prodManagersUI = new List<ProducerManagerUI>();
            prodManagers = new List<ProducerManager>();

            BoxProduction boxProdA = new BoxProduction(
                "A",
                10000,
                20,
                20
            );
            ManagerA = new ProducerManager(boxProdA);
            prodManagers.Add(ManagerA);

            BoxProduction boxProdB = new BoxProduction(
                 "B",
                5000,
                25000,
                5
            );
            ManagerB = new ProducerManager(boxProdB);
            prodManagers.Add(ManagerB);

            BoxProduction boxProdC = new BoxProduction(
                "C",
                10000,
                120000,
                10
            );
            ManagerC = new ProducerManager(boxProdC);
            prodManagers.Add(ManagerC);

            InitializeComponent();

            prodManagersUI.Add(new ProducerManagerUI(
                ManagerA,
                producerSpecsA,
                producerLoadingA,
                this
            ));

            prodManagersUI.Add(new ProducerManagerUI(
                ManagerB,
                producerSpecsB,
                producerLoadingB,
                this
            ));

            prodManagersUI.Add(new ProducerManagerUI(
                ManagerC,
                producerSpecsC,
                producerLoadingC,
                this
            ));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitTimeClockStatus();

            foreach (ProducerManagerUI prodManUI in prodManagersUI)
            {
                switch(prodManUI.ToString())
                {
                    case "A":
                        prodManUI.BindLaunch(menuiLaunchA);
                        prodManUI.BindLaunch(bLaunchA);
                        prodManUI.BindStop(menuiStopA);
                        prodManUI.BindStop(bStopA);
                        prodManUI.BindStart(menuiStartA);
                        prodManUI.BindStart(bStartA);
                        prodManUI.InfoStatus = statusProdA;
                        break;
                    case "B":
                        prodManUI.BindLaunch(menuiLaunchB);
                        prodManUI.BindLaunch(bLaunchB);
                        prodManUI.BindStop(menuiStopB);
                        prodManUI.BindStop(bStopB);
                        prodManUI.BindStart(menuiStartB);
                        prodManUI.BindStart(bStartB);
                        prodManUI.InfoStatus = statusProdB;
                        break;
                    case "C":
                        prodManUI.BindLaunch(menuiLaunchC);
                        prodManUI.BindLaunch(bLaunchC);
                        prodManUI.BindStop(menuiStopC);
                        prodManUI.BindStop(bStopC);
                        prodManUI.BindStart(menuiStartC);
                        prodManUI.BindStart(bStartC);
                        prodManUI.InfoStatus = statusProdC;
                        break;
                }
            }
        }

        private void InitTimeClockStatus()
        {
            statusTime.Text = DateTime.Now.ToString("HH:mm:ss");

            timerTime.Interval = 1000;
            timerTime.Tick += (object? sender, EventArgs e) =>
            {
                statusTime.Text = DateTime.Now.ToString("HH:mm:ss");
            };
            timerTime.Start();
        }

        private void Event_LaunchProduction(object sender, EventArgs e)
        {
            ProducerManagerUI.ExecActionFromButtons(ProducerState.created, sender);
        }

        private void Event_StartProduction(object sender, EventArgs e)
        {
            ProducerManagerUI.ExecActionFromButtons(ProducerState.started, sender);
        }

        private void Event_StopProduction(object sender, EventArgs e)
        {
            ProducerManagerUI.ExecActionFromButtons(ProducerState.stopped, sender);
        }

        private void Event_ShutdownAll(object? sender, EventArgs e)
        {
            ShutdownAllProducers();
        }

        private void menuiQuitApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult response = MessageBox.Show(
                "Voulez vous quitter ?",
                "Quitter",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (response == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                ShutdownAllProducers();
            }
        }

        private void ShutdownAllProducers()
        {
            foreach (ProducerManagerUI prodManUI in prodManagersUI)
            {
                prodManUI.Shutdown();
            }
        }
    }
}
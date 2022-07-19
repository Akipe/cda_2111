using ToutEmbalCore;
using ToutEmbalCore.Managers;
using ToutEmbalCore.Producers;
using ToutEmbalUI.Libs;

namespace ToutEmbalUI
{
    public partial class MainForm : Form
    {
        private List<IManager> _managers;

        public MainForm()
        {
            InitializeComponent();

            _managers = new List<IManager>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitTimeClockStatus();

            IManager managerA = new ProducerManager(
                new BoxProduction(
                    "A",
                    1000,
                    10000,
                    2
                )
            );

            IManager managerB = new ProducerManager(
                new BoxProduction(
                    "B",
                    5000,
                    25000,
                    5
                )
            );

            IManager managerC = new ProducerManager(
                new BoxProduction(
                    "C",
                    10000,
                    120000,
                    10
                )
            );

            ManagerUIBuilder buildUIa = new ManagerUIBuilder(managerA);
            buildUIa
                .AddStatus(statusProdA)
                .AddSpecs(producerSpecsA)
                .AddLoading(producerLoadingA)
                .AddLaunchButtons(new object[] { menuiLaunchA, bLaunchA })
                .AddStopButtons(new object[] { menuiStopA, bStopA })
                .AddStartButtons(new object[] { menuiStartA, bStartA })
            ;

            ManagerUIBuilder buildUIb = new ManagerUIBuilder(managerB);
            buildUIb
                .AddStatus(statusProdB)
                .AddSpecs(producerSpecsB)
                .AddLoading(producerLoadingB)
                .AddLaunchButtons(new object[] { menuiLaunchB, bLaunchB })
                .AddStopButtons(new object[] { menuiStopB, bStopB })
                .AddStartButtons(new object[] { menuiStartB, bStartB })
            ;

            ManagerUIBuilder buildUIc = new ManagerUIBuilder(managerC);
            buildUIc
                .AddStatus(statusProdC)
                .AddSpecs(producerSpecsC)
                .AddLoading(producerLoadingC)
                .AddLaunchButtons(new object[] { menuiLaunchC, bLaunchC })
                .AddStopButtons(new object[] { menuiStopC, bStopC })
                .AddStartButtons(new object[] { menuiStartC, bStartC })
            ;

            _managers = ManagerUIBuilder.Managers;
        }

        private void InitTimeClockStatus()
        {
            setCurrentTime();

            timerTime.Interval = 1000;
            timerTime.Tick += (object? sender, EventArgs e) =>
            {
                setCurrentTime();
            };
            timerTime.Start();
        }

        private void setCurrentTime()
        {
            statusTime.Text = DateTime.Now.ToString("HH:mm:ss");
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
            foreach (ProducerManager manager in _managers)
            {
                manager.Shutdown();
            }
        }
    }
}
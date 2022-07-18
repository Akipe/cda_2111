using ToutEmbalCore;

namespace ToutEmbalUI
{
    public partial class MainForm : Form
    {
        List<ProducerManager> prodManagers;

        ProducerManager ManagerA { get; init; }
        ProducerManager ManagerB { get; init; }
        ProducerManager ManagerC { get; init; }

        public MainForm()
        {
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

            ManagerUIBuilder buildA = new ManagerUIBuilder(ManagerA);
            buildA
                .AddStatus(statusProdA)
                .AddSpecs(producerSpecsA)
                .AddLoading(producerLoadingA)
                .AddForm(this)
                .AddLaunchButtons(new object[] { menuiLaunchA, bLaunchA })
                .AddStopButtons(new object[] { menuiStopA, bStopA })
                .AddStartButtons(new object[] { menuiStartA, bStartA })
            ;

            ManagerUIBuilder buildB = new ManagerUIBuilder(ManagerB);
            buildB
                .AddStatus(statusProdB)
                .AddSpecs(producerSpecsB)
                .AddLoading(producerLoadingB)
                .AddForm(this)
                .AddLaunchButtons(new object[] { menuiLaunchB, bLaunchB })
                .AddStopButtons(new object[] { menuiStopB, bStopB })
                .AddStartButtons(new object[] { menuiStartB, bStartB })
            ;

            ManagerUIBuilder buildC = new ManagerUIBuilder(ManagerC);
            buildC
                .AddStatus(statusProdC)
                .AddSpecs(producerSpecsC)
                .AddLoading(producerLoadingC)
                .AddForm(this)
                .AddLaunchButtons(new object[] { menuiLaunchC, bLaunchC })
                .AddStopButtons(new object[] { menuiStopC, bStopC })
                .AddStartButtons(new object[] { menuiStartC, bStartC })
            ;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitTimeClockStatus();
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
            foreach (ProducerManager manager in ManagerUIBuilder.Managers)
            {
                manager.Shutdown();
            }
        }
    }
}
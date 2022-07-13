using ToutEmbalCore;

namespace ToutEmbalUI
{
    public partial class MainForm : Form
    {
        List<ProducerManagerUI> prodManagersUI;

        public MainForm()
        {
            InitializeComponent();
            prodManagersUI = new List<ProducerManagerUI>();

            ProducerManager prodManA = new ProducerManager(new BoxProduction(
                "A",
                10000,
                20,
                20
            ));
            prodManagersUI.Add(new ProducerManagerUI(
                prodManA,
                producerSpecsA,
                producerLoadingA,
                this
            ));

            ProducerManager prodManB = new ProducerManager(new BoxProduction(
                 "B",
                5000,
                25000,
                5
            ));
            prodManagersUI.Add(new ProducerManagerUI(
                prodManB,
                producerSpecsB,
                producerLoadingB,
                this
            ));

            ProducerManager prodManC = new ProducerManager(new BoxProduction(
                "C",
                10000,
                120000,
                10
            ));
            prodManagersUI.Add(new ProducerManagerUI(
                prodManC,
                producerSpecsC,
                producerLoadingC,
                this
            ));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            /*prodManUIA.Manager.Start();
            prodManUIB.Manager.Start();
            prodManUIC.Manager.Start();*/

            statusTime.Text = DateTime.Now.ToString("HH:mm:ss");
            timerTime.Interval = 1000;
            timerTime.Tick += (object? sender, EventArgs e) =>
            {
                statusTime.Text = DateTime.Now.ToString("HH:mm:ss");
            };
            timerTime.Start();

            foreach(ProducerManagerUI prodManUI in prodManagersUI)
            {
                switch(prodManUI.ToString())
                {
                    case "A":
                        prodManUI.BindLaunch(menuiLaunchA);
                        prodManUI.BindLaunch(bALaunch);
                        prodManUI.BindStop(menuiStopA);
                        prodManUI.BindStop(bAStop);
                        prodManUI.BindStart(menuiStartA);
                        prodManUI.BindStart(bAStart);
                        prodManUI.InfoStatus = statusProdA;
                        break;
                    case "B":
                        prodManUI.BindLaunch(menuiLaunchB);
                        prodManUI.BindLaunch(bBLaunch);
                        prodManUI.BindStop(menuiStopB);
                        prodManUI.BindStop(bBStop);
                        prodManUI.BindStart(menuiStartB);
                        prodManUI.BindStart(bBStart);
                        prodManUI.InfoStatus = statusProdB;
                        break;
                    case "C":
                        prodManUI.BindLaunch(menuiLaunchC);
                        prodManUI.BindLaunch(bALaunch);
                        prodManUI.BindStop(menuiStopC);
                        prodManUI.BindStop(bCStop);
                        prodManUI.BindStart(menuiStartC);
                        prodManUI.BindStart(bCStart);
                        prodManUI.InfoStatus = statusProdC;
                        break;
                }

                //prodManUI.UpdateStatusManagerActions();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //boxProdA.Stop();
        }

        private void Event_LaunchProduction(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem)
            {
                if (menuItem.Tag is ProducerManagerUI managerUI)
                {
                    managerUI.Launch();
                }
            }
        }

        private void Event_StartProduction(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem)
            {
                if (menuItem.Tag is ProducerManagerUI managerUI)
                {
                    managerUI.Start();
                }
            }
        }

        private void Event_StopProduction(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem)
            {
                if (menuItem.Tag is ProducerManagerUI managerUI)
                {
                    managerUI.Stop();
                }
            }
        }

        private void Event_ShutdownAll(object? sender, EventArgs e)
        {
            foreach (ProducerManagerUI prodManUI in prodManagersUI)
            {
                prodManUI.Shutdown();
            }
        }

        private void menuiQuitApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Voulez vous quitter ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                foreach(ProducerManagerUI prodManUI in prodManagersUI)
                {
                    prodManUI.Shutdown();
                }
            }
        }
    }
}
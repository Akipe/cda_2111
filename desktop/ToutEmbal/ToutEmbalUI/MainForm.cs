using ToutEmbalCore;

namespace ToutEmbalUI
{
    public partial class MainForm : Form
    {
        ProducerManagerUI prodManUIA;
        ProducerManagerUI prodManUIB;
        ProducerManagerUI prodManUIC;

        public MainForm()
        {
            InitializeComponent();

            ProducerManager prodManA = new ProducerManager(new BoxProduction(
                "A",
                10000,
                20,
                20
            ));
            prodManUIA = new ProducerManagerUI(
                prodManA,
                producerSpecsA,
                producerLoadingA
            );

            ProducerManager prodManB = new ProducerManager(new BoxProduction(
                 "B",
                5000,
                25000,
                5
            ));
            prodManUIB = new ProducerManagerUI(
                prodManB,
                producerSpecsB,
                producerLoadingB
            );

            ProducerManager prodManC = new ProducerManager(new BoxProduction(
                "C",
                10000,
                120000,
                10
            ));
            prodManUIC = new ProducerManagerUI(
                prodManC,
                producerSpecsC,
                producerLoadingC
            );
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            /*prodManUIA.Manager.Start();
            prodManUIB.Manager.Start();
            prodManUIC.Manager.Start();*/

            prodManUIA.AttachOn(menuiInitA); 
            prodManUIA.AttachOn(menuiShutdownA);
            prodManUIA.AttachOn(menuiResumeA);

            prodManUIB.AttachOn(menuiInitB);
            prodManUIB.AttachOn(menuiShutdownB);
            prodManUIB.AttachOn(menuiResumeB);

            prodManUIC.AttachOn(menuiInitC);
            prodManUIC.AttachOn(menuiShutdownC);
            prodManUIC.AttachOn(menuiResumeC);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //boxProdA.Stop();
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
            prodManUIA.Shutdown();
            prodManUIB.Shutdown();
            prodManUIC.Shutdown();
        }
    }
}
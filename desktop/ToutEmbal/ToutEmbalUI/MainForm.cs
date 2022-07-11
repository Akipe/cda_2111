using ToutEmbalCore;

namespace ToutEmbalUI
{
    public partial class MainForm : Form
    {
        BoxProduction boxProdA;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            boxProdA = new BoxProduction(
                "A",
                1000
            );

            timerProduceA.Interval = boxProdA.MilisecondsForOneProduct;
            //timerProduceA.Interval = 100;
            timerProduceA.Tick += new EventHandler(UpdateProductionACount);
            timerProduceA.Start();

            Thread tBoxProdA = new Thread(() =>
            {
                boxProdA.Start();
            });
            tBoxProdA.Start();

            labelPRoduceA.Text = boxProdA.NbDone.ToString();
            //boxProdA.Stop();
        }

        private void UpdateProductionACount(Object? sender, EventArgs e)
        {
            labelPRoduceA.Text = boxProdA.NbDone.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            boxProdA.Stop();
        }
    }
}
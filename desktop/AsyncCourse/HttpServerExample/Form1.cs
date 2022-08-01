namespace HttpServerExample
{
    public partial class Form1 : Form
    {
        WebServer Server { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Server = new WebServer();

            bStart.Text = "Start";
            bStart.BackColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Server.Running)
            {
                Server.Start();
                bStart.Text = "Stop";
                bStart.BackColor = Color.Red;

                tbLog.Text += "Start server at http://localhost:8000/" + System.Environment.NewLine;
            }
            else
            {
                Server.Stop();
                bStart.Text = "Start";
                bStart.BackColor = Color.Green;

                tbLog.Text += "Stop server" + System.Environment.NewLine;
            }
        }
    }
}
using System;
using System.Runtime.InteropServices;


namespace AsyncCourse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(AddText);
            thread.Start();
            // Si l'on veut supprimer le processus créer ci-dessus
            // thread.Join();

            Thread thread2 = new Thread(AddText2);
            thread2.Start("Oh");
        }
        private void AddText()
        {
            Thread.Sleep(5000);

            // Ici on réalise des traitements dans un autre processus
            // On réalise ici le traitement lourd

            // Methode délégué
            this.Invoke(new MethodInvoker(() =>
            {
                // Ici on réalise le traitement dans le processus principal
                // on peut accéder aux données du processus principal ici
                txtResult.Text += "Yeah ";
            }));

            Thread.Sleep(5000);
        }

        private void AddText2(object txt)
        {
            Thread.Sleep(2000);

            // Ici on réalise des traitements dans un autre processus
            // On réalise ici le traitement lourd

            // Methode délégué
            this.Invoke(new MethodInvoker(() =>
            {
                // Ici on réalise le traitement dans le processus principal
                // on peut accéder aux données du processus principal ici
                txtResult.Text += txt.ToString() + ' ';
            }));

            Thread.Sleep(2000);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
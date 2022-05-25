namespace Training02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonNameEmptying_Click(object sender, EventArgs e)
        {
            this.EmptyAllTextBoxNames();
        }

        private void buttonNameOk_Click(object sender, EventArgs e)
        {
            listBoxAllNames.Items.Add(textBoxFirstname.Text + " " + textBoxLastname.Text);

            this.EmptyAllTextBoxNames();
        }
        
        private void EmptyAllTextBoxNames()
        {
            textBoxFirstname.Text = "";
            textBoxLastname.Text = "";
        }

        private void razToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxAllNames.Items.Clear();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aProposDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Cette application a été développé avec amour <3",
                "A propos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }
    }
}
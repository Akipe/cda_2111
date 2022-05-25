namespace _01_MagicButton
{
    public partial class Form1 : Form
    {
        private int spaceBetweenWindowAndButton;
        private int HeightToWalk;

        public Form1()
        {
            InitializeComponent();
        }

        private void magicButton_Click(object sender, EventArgs e)
        {
            //this.WidthToWalk = this.
            //magicButton.Text = this.Height + " " + this.Width;

            //magicButton.Width
            this.spaceBetweenWindowAndButton = magicButton.Left;
            magicButton.Left = this.Width - magicButton.Width - magicButton.Margin.Left - magicButton.Padding.Left - this.spaceBetweenWindowAndButton;
        }
    }
}
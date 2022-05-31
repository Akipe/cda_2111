namespace _02_simple_addition
{
    public partial class SimpleAdditionForm : Form
    {
        private SimpleAddition SimpleAdditionInstance { get; set; }

        public SimpleAdditionForm()
        {
            InitializeComponent();

            SimpleAdditionInstance = new SimpleAddition();
        }

        private void BtnDigit_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                int number = Int32.Parse(btn.Text);

                SimpleAdditionInstance.Add(number);
                UpdateCalculateDisplay();
            }
        }

        private void BtnEmptying_Click(object sender, EventArgs e)
        {
            SimpleAdditionInstance.Reset();
            UpdateCalculateDisplay();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            SimpleAdditionInstance.Calculate();
            UpdateCalculateDisplay();
        }

        private void UpdateCalculateDisplay()
        {
            this.TbCalculateDisplay.Text = SimpleAdditionInstance.PrintableResult;
        }
    }
}
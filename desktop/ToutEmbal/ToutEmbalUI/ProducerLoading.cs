using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToutEmbalCore;

namespace ToutEmbalUI
{
    public partial class ProducerLoading : UserControl
    {
        public ProducerManager? Manager { get; set; }

        public ProducerLoading()
        {
            InitializeComponent();

            Manager = null;
        }

        private void ProducerLoading_Load(object? sender, EventArgs e)
        {
            lProduceTime.Text = "Production " + Manager.Unit.GetName();

            pbTimeProduce.Minimum = 0;
            pbTimeProduce.Maximum = Manager.Unit.GetNbWanted();

            UpdateProcessBar(null, new EventArgs());
        }

        public void UpdateProcessBar(object? sender, EventArgs e)
        {
            if (Manager != null)
            {
                Invoke(test);
            }
        }

        private void test()
        {
            pbTimeProduce.Value = Manager.Unit.GetProduction();
        }
    }
}

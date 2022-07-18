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
        public ProducerManager Manager { get; init; }

        public ProducerLoading(ProducerManager manager)
        {
            InitializeComponent();

            Manager = manager;
        }

        private void ProducerLoading_Load(object? sender, EventArgs e)
        {
            lProduceTime.Text = "Production " + Manager.Unit.GetName();

            pbTimeProduce.Minimum = 0;
            pbTimeProduce.Maximum = Manager.Unit.GetNbWanted();

            Manager.Unit.OnCreateOne += UpdateProcessBarThreadSafe;
            UpdateProcessBarThreadSafe(null, EventArgs.Empty);
        }

        public void UpdateProcessBarThreadSafe(object? sender, EventArgs e)
        {
            if (Manager != null)
            {
                try
                {
                    Invoke(updateProcessBar);
                }
                catch (InvalidOperationException)
                {
                    updateProcessBar();
                }
            }
        }

        private void updateProcessBar()
        {
            pbTimeProduce.Value = Manager.Unit.GetProduction();
        }
    }
}

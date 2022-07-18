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
    public partial class ProducerSpecs : UserControl
    {
        public ProducerManager Manager { get; init; }

        public ProducerSpecs(ProducerManager manager)
        {
            InitializeComponent();

            Manager = manager;
        }

        private void ProducerSpecs_Load(object? sender, EventArgs e)
        {
            Manager.Unit.OnCreateOne += UpdateSpecsThreadSafe;
            UpdateSpecsThreadSafe(null, EventArgs.Empty);
        }

        public void UpdateSpecsThreadSafe(object? sender, EventArgs e)
        {
            if (Manager != null)
            {
                try
                {
                    Invoke(UpdateSpecs);
                }
                catch (InvalidOperationException)
                {
                    UpdateSpecs();
                }
            }
        }

        private void UpdateSpecs()
        {
            tbNbProducts.Text = Manager.Unit.GetProduction().ToString();
            tbDefectRateLastHour.Text = Manager.Unit.GetLastHourRateDefect().ToString("0.0000");
            tbDefectRateAllTime.Text = Manager.Unit.GetTotalRateDefect().ToString("0.0000");
        }
    }
}

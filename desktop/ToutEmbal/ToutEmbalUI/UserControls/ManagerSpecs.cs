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
    public partial class ManagerSpecs : UserControl
    {
        private ProducerManager? _manager;

        public ProducerManager? Manager {
            get
            {
                return _manager;
            }
            set
            {
                _manager = value;

                if (Manager is not null)
                {
                    OnManagerDefine();
                }
            }
        }

        public ManagerSpecs()
        {
            InitializeComponent();
            Manager = null;
        }

        private void OnManagerDefine()
        {
            Manager.Unit.OnCreateOne += UpdateSpecsThreadSafe;
            UpdateSpecsThreadSafe(null, EventArgs.Empty);
        }

        private void UpdateSpecsThreadSafe(object? sender, EventArgs e)
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

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
    public partial class ProductionStats : UserControl
    {
        private IManager? _manager;

        public IManager? Manager {
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

        public ProductionStats()
        {
            InitializeComponent();
            Manager = null;
        }

        private void OnManagerDefine()
        {
            Manager.GetUnit().OnCreateOne += UpdateSpecsThreadSafe;
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
            tbNbProducts.Text = Manager.GetUnit().GetProduction().ToString();
            tbDefectRateLastHour.Text = Manager.GetUnit().GetLastHourRateDefect().ToString("0.0000");
            tbDefectRateAllTime.Text = Manager.GetUnit().GetTotalRateDefect().ToString("0.0000");
        }
    }
}

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
    public partial class ProductionProgress : UserControl
    {
        private IManager? _manager;
        public IManager? Manager
        {
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

        public ProductionProgress()
        {
            InitializeComponent();

            Manager = null;
        }

        private void OnManagerDefine()
        {
            lProduceTime.Text = "Production " + Manager.GetUnit().GetName();

            pbTimeProduce.Minimum = 0;
            pbTimeProduce.Maximum = Manager.GetUnit().GetNbWanted();

            Manager.GetUnit().OnCreateOne += UpdateProcessBarThreadSafe;
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
            pbTimeProduce.Value = Manager.GetUnit().GetProduction();
        }
    }
}

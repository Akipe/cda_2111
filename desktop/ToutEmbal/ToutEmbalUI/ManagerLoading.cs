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
    public partial class ManagerLoading : UserControl
    {
        private ProducerManager? _manager;
        public ProducerManager? Manager
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

        public ManagerLoading()
        {
            InitializeComponent();

            Manager = null;
        }

        private void OnManagerDefine()
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

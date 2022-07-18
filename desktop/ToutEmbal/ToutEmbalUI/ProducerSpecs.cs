﻿using System;
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
        public ProducerManager? Manager { get; set; }

        public ProducerSpecs()
        {
            InitializeComponent();

            Manager = null;
        }

        private void ProducerSpecs_Load(object? sender, EventArgs e)
        {
            UpdateSpecsThreadSafe(null, new EventArgs());
        }

        public void UpdateSpecsThreadSafe(object? sender, EventArgs e)
        {
            if (Manager != null)
            {
                try
                {
                    Invoke(UpdateSpecs);
                }
                catch (InvalidOperationException error)
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

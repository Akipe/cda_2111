using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToutEmbalCore;
using Timer = System.Windows.Forms.Timer;

namespace ToutEmbalUI
{
    public class ProducerManagerUI
    {
        public ProducerManager Manager { get; init; }
        public ProducerSpecs SpecsUI { get; init; }
        public ProducerLoading LoadingUI { get; init; }
        private Timer ProdTimer { get; init; }

        public ProducerManagerUI(
            ProducerManager manager,
            ProducerSpecs specsUI,
            ProducerLoading loadingUI
        )
        {
            Manager = manager;
            SpecsUI = specsUI;
            SpecsUI.Manager = Manager;
            LoadingUI = loadingUI;
            LoadingUI.Manager = Manager;

            ProdTimer = new Timer();
            ProdTimer.Interval = Manager.Unit.GetMilisecondsForCreateOne() / 2;
            ProdTimer.Tick += LoadingUI.UpdateProcessBar;
            ProdTimer.Tick += SpecsUI.UpdateSpecs;
            
        }

        public void Start()
        {
            Manager.Start();
            ProdTimer.Start();
        }

        public void Stop()
        {
            Manager.Stop();
            ProdTimer.Stop();
        }

        public void Shutdown()
        {
            Manager.Shutdown();
            ProdTimer.Stop();
        }

        public void AttachOn(Control control)
        {
            control.Tag = this;
        }

        public void AttachOn(ToolStripMenuItem control)
        {
            control.Tag = this;
        }
    }
}

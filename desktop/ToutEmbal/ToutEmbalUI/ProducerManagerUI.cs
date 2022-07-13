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
        private ToolStripStatusLabel _infoStatus;

        public ProducerManager Manager { get; init; }
        public ProducerSpecs SpecsUI { get; init; }
        public ProducerLoading LoadingUI { get; init; }
        private Form MainForm { get; set; }
        private Timer ProdTimer { get; init; }

        public List<object> LaunchObjsForm { get; private set; }
        public List<object> StopObjsForm { get; private set; }
        public List<object> StartObjsForm { get; private set; }
        public List<object> ShutdownObjsForm { get; private set; }

        public ToolStripStatusLabel InfoStatus {
            get
            {
                return _infoStatus;
            }
            set
            {
                _infoStatus = value;
                UpdateStatusInfoEvent(this, new EventArgs());
            }
        }

        public ProducerManagerUI(
            ProducerManager manager,
            ProducerSpecs specsUI,
            ProducerLoading loadingUI,
            Form form
        )
        {
            Manager = manager;
            SpecsUI = specsUI;
            SpecsUI.Manager = Manager;
            LoadingUI = loadingUI;
            LoadingUI.Manager = Manager;
            MainForm = form;

            Manager.Unit.OnStateChanged += TriggerStatusManagerActions;
            Manager.Unit.OnStateChanged += UpdateStatusInfoEvent;

            LaunchObjsForm = new List<object>();
            StopObjsForm = new List<object>();
            StartObjsForm = new List<object>();
            ShutdownObjsForm = new List<object>();

            ProdTimer = new Timer();
            ProdTimer.Interval = Manager.Unit.GetMilisecondsForCreateOne() / 2;
            ProdTimer.Tick += LoadingUI.UpdateProcessBar;
            ProdTimer.Tick += SpecsUI.UpdateSpecs;
        }

        public void Launch()
        {
            var test = Manager.Unit.GetState();
            /*if (Manager.Unit.GetState() == ProducerState.created)
            {*/
                Manager.Launch();
                ProdTimer.Start();
            /*}*/
        }

        public void Stop()
        {
            /*if (Manager.Unit.GetState() == ProducerState.started)
            {*/
                Manager.Stop();
                ProdTimer.Stop();
            /*}*/
        }

        public void Start()
        {
            /*if (Manager.Unit.GetState() == ProducerState.stopped)
            {*/
                Manager.Start();
                ProdTimer.Start();
            /*}*/
        }

        public void Shutdown()
        {
            /*if (Manager.Unit.GetState() != ProducerState.created)
            {*/
                Manager.Shutdown();
                ProdTimer.Stop();
            /*}*/
        }

        public void AttachOn(object controlObj)
        {
            if (controlObj is Control control)
            {
                control.Tag = this;
            }
            if (controlObj is ToolStripMenuItem menuItem)
            {
                menuItem.Tag = this;
            }
        }

        public void BindLaunch(object control)
        {
            AttachOn(control);
            LaunchObjsForm.Add(control);
        }

        public void BindStop(object control)
        {
            AttachOn(control);
            StopObjsForm.Add(control);
        }

        public void BindStart(object control)
        {
            AttachOn(control);
            StartObjsForm.Add(control);

        }

        public void BindShutdown(object control)
        {
            AttachOn(control);
            ShutdownObjsForm.Add(control);
        }

        public override string ToString()
        {
            return Manager.ToString();
        }

        /*public void UpdateStatusManagerActions()
        {
            TriggerStatusManagerActions(this, new EventArgs());
        }*/

        private void TriggerStatusManagerActions(object? sender, EventArgs e)
        {
            MainForm.Invoke(new MethodInvoker(() =>
            {
                var test = Manager.Unit.GetState();
                switch (Manager.Unit.GetState())
                {
                    case ProducerState.created:
                        EnableObjsForm(LaunchObjsForm);
                        DisableObjsForm(StopObjsForm);
                        DisableObjsForm(StartObjsForm);
                        DisableObjsForm(ShutdownObjsForm);
                        break;
                    case ProducerState.started:
                        DisableObjsForm(LaunchObjsForm);
                        EnableObjsForm(StopObjsForm);
                        DisableObjsForm(StartObjsForm);
                        EnableObjsForm(ShutdownObjsForm);
                        break;
                    case ProducerState.stopped:
                        DisableObjsForm(LaunchObjsForm);
                        DisableObjsForm(StopObjsForm);
                        EnableObjsForm(StartObjsForm);
                        EnableObjsForm(ShutdownObjsForm);
                        break;
                    case ProducerState.shutdown:
                        DisableObjsForm(LaunchObjsForm);
                        DisableObjsForm(StopObjsForm);
                        DisableObjsForm(StartObjsForm);
                        DisableObjsForm(ShutdownObjsForm);
                        break;
                }
            }));
        }

        private void UpdateStatusInfoEvent(object? sender, EventArgs e)
        {
            string valueState = "";

            switch(Manager.Unit.GetState())
            {
                case ProducerState.created:
                    valueState = "Initialisé";
                    break;
                case ProducerState.started:
                    valueState = "Démarré";
                    break;
                case ProducerState.stopped:
                    valueState = "Suspendu";
                    break;
                case ProducerState.shutdown:
                    valueState = "Terminé";
                    break;
            }

            InfoStatus.Text = $"Caisse {Manager.Unit.GetName()}: {valueState}";
        }

        private void DisableObjsForm(List<object> objsForm)
        {
            foreach(object objForm in objsForm)
            {
                if (objForm is ToolStripMenuItem menuItem)
                {
                    menuItem.Enabled = false;
                }
                if (objForm is Control control)
                {
                    control.Enabled = false;
                }
            }
        }

        private void EnableObjsForm(List<object> objsForm)
        {
            foreach (object objForm in objsForm)
            {
                if (objForm is ToolStripMenuItem menuItem)
                {
                    menuItem.Enabled = true;
                }
                if (objForm is Control control)
                {
                    control.Enabled = false;
                }
            }
        }
    }
}

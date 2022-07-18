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

            Manager.Unit.OnStateChanged += TriggerStatusManagerActionsOtherThread;
            Manager.Unit.OnStateChanged += UpdateStatusInfoEvent;

            LaunchObjsForm = new List<object>();
            StopObjsForm = new List<object>();
            StartObjsForm = new List<object>();
            ShutdownObjsForm = new List<object>();

            Manager.Unit.OnCreateOne += LoadingUI.UpdateProcessBar;
            Manager.Unit.OnCreateOne += SpecsUI.UpdateSpecs;

        }

        public void Launch()
        {
            var test = Manager.Unit.GetState();
            /*if (Manager.Unit.GetState() == ProducerState.created)
            {*/
                Manager.Launch();
            /*}*/
        }

        public void Stop()
        {
            /*if (Manager.Unit.GetState() == ProducerState.started)
            {*/
                Manager.Stop();
            /*}*/
        }

        public void Start()
        {
            /*if (Manager.Unit.GetState() == ProducerState.stopped)
            {*/
                Manager.Start();
            /*}*/
        }

        public void Shutdown()
        {
            /*if (Manager.Unit.GetState() != ProducerState.created)
            {*/
                Manager.Shutdown();
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

            TriggerStatusManagerActions();
        }

        public void BindLaunch(object control)
        {
            LaunchObjsForm.Add(control);
            AttachOn(control);
        }

        public void BindStop(object control)
        {
            StopObjsForm.Add(control);
            AttachOn(control);
        }

        public void BindStart(object control)
        {
            StartObjsForm.Add(control);
            AttachOn(control);
        }

        public void BindShutdown(object control)
        {
            ShutdownObjsForm.Add(control);
            AttachOn(control);
        }

        public override string ToString()
        {
            return Manager.ToString();
        }

        private void TriggerStatusManagerActionsOtherThread(object? sender, EventArgs e)
        {
            MainForm.Invoke(new MethodInvoker(() =>
            {
                TriggerStatusManagerActions();
            }));
        }

        private void TriggerStatusManagerActions()
        {
            var debug = Manager.Unit.GetState();

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
                    control.Enabled = true;
                }
            }
        }

        public static void ExecActionFromButtons(ProducerState state, object sender)
        {
            ProducerManagerUI? managerUI = null;

            if (sender is ToolStripMenuItem menuItem)
            {
                if (menuItem.Tag is ProducerManagerUI)
                {
                    managerUI = (ProducerManagerUI)menuItem.Tag;
                }
            }
            if (sender is Control control)
            {
                if (control.Tag is ProducerManagerUI)
                {
                    managerUI = (ProducerManagerUI)control.Tag;
                }
            }

            if (managerUI is not null)
            {
                switch (state)
                {
                    case ProducerState.created:
                        managerUI.Launch();
                        break;
                    case ProducerState.stopped:
                        managerUI.Stop();
                        break;
                    case ProducerState.started:
                        managerUI.Start();
                        break;
                    case ProducerState.shutdown:
                        managerUI.Shutdown();
                        break;
                }
            }
        }
    }
}

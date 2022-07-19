using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToutEmbalCore;

namespace ToutEmbalUI.Libs
{
    public class ManagerCommand
    {
        public ProducerManager Manager { get; init; }
        public List<object> LaunchBtns { get; private set; }
        public List<object> StopBtns { get; private set; }
        public List<object> StartBtns { get; private set; }
        public List<object> ShutdownBtns { get; private set; }

        public ManagerCommand(
            ProducerManager manager
        )
        {
            Manager = manager;

            LaunchBtns = new List<object>();
            StopBtns = new List<object>();
            StartBtns = new List<object>();
            ShutdownBtns = new List<object>();

            Manager.Unit.OnStateChanged += SetAvailability;
        }

        public void BindLaunch(object control)
        {
            LaunchBtns.Add(control);
            Personalize(control);
        }

        public void BindStop(object control)
        {
            StopBtns.Add(control);
            Personalize(control);
        }

        public void BindStart(object control)
        {
            StartBtns.Add(control);
            Personalize(control);
        }

        public void BindShutdown(object control)
        {
            ShutdownBtns.Add(control);
            Personalize(control);
        }

        private void Personalize(object controlObj)
        {
            if (controlObj is Control control)
            {
                control.Tag = this;
                control.Click += EventRunAction;
            }
            if (controlObj is ToolStripMenuItem menuItem)
            {
                menuItem.Tag = this;
                menuItem.Click += EventRunAction;
            }

            SetAvailability(this, EventArgs.Empty);
        }

        private void SetAvailability(object? sender, EventArgs e)
        {
            switch (Manager.Unit.GetState())
            {
                case ProducerState.created:
                    Enable(LaunchBtns);
                    Disable(StopBtns);
                    Disable(StartBtns);
                    Disable(ShutdownBtns);
                    break;
                case ProducerState.started:
                    Disable(LaunchBtns);
                    Enable(StopBtns);
                    Disable(StartBtns);
                    Enable(ShutdownBtns);
                    break;
                case ProducerState.stopped:
                    Disable(LaunchBtns);
                    Disable(StopBtns);
                    Enable(StartBtns);
                    Enable(ShutdownBtns);
                    break;
                case ProducerState.shutdown:
                    Disable(LaunchBtns);
                    Disable(StopBtns);
                    Disable(StartBtns);
                    Disable(ShutdownBtns);
                    break;
            }
        }

        private void Disable(List<object> buttons)
        {
            TriggerAvailableThreadSafe(false, buttons);
        }

        private void Enable(List<object> buttons)
        {
            TriggerAvailableThreadSafe(true, buttons);
        }

        private void TriggerAvailableThreadSafe(bool isEnable, List<object> buttons)
        {
            foreach (object button in buttons)
            {
                if (button is Control control)
                {
                    Form buttonForm = control.FindForm();

                    if (buttonForm.InvokeRequired)
                    {
                        buttonForm.Invoke(new Action(() =>
                        {
                            TriggerAvailable(isEnable, button);
                        }));
                    }
                    else
                    {
                        TriggerAvailable(isEnable, button);
                    }
                }
                else if (button is ToolStripMenuItem menuItem)
                {
                    var toolStrip = menuItem.OwnerItem.GetCurrentParent();

                    if (toolStrip.InvokeRequired)
                    {
                        toolStrip.Invoke(new Action(() =>
                        {
                            TriggerAvailable(isEnable, button);
                        }));
                    }
                    else
                    {
                        TriggerAvailable(isEnable, button);
                    }
                }
                else
                {
                    throw new Exception("Buttons has to be Control or ToolStripMenuItem");
                }
            }
        }

        private void TriggerAvailable(bool isEnable, object button)
        {
            if (button is ToolStripMenuItem menuItem)
            {
                menuItem.Enabled = isEnable;
            }
            if (button is Control control)
            {
                control.Enabled = isEnable;
            }
        }


        private ManagerCommand? GetManagerButtonFromTag(ToolStripMenuItem control)
        {
            if (control.Tag is ManagerCommand)
            {
                return (ManagerCommand)control.Tag;
            }

            return null;
        }

        private ManagerCommand? GetManagerButtonFromTag(Control control)
        {
            if (control.Tag is ManagerCommand)
            {
                return (ManagerCommand)control.Tag;
            }

            return null;
        }

        private void EventRunAction(object? sender, EventArgs e)
        {
            ManagerCommand? managerBtn = null;

            switch (sender)
            {
                case ToolStripMenuItem menuItem:
                    managerBtn = GetManagerButtonFromTag(menuItem);
                    break;
                case Control control:
                    managerBtn = GetManagerButtonFromTag(control);
                    break;
            }

            if (managerBtn is not null)
            {
                if (LaunchBtns.Contains(sender))
                {
                    managerBtn.Manager.Launch();
                }
                else if (StopBtns.Contains(sender))
                {
                    managerBtn.Manager.Stop();
                }
                else if (StartBtns.Contains(sender))
                {
                    managerBtn.Manager.Start();
                }
                else if (ShutdownBtns.Contains(sender))
                {
                    managerBtn.Manager.Shutdown();
                }
            }
        }
    }
}

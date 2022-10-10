using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToutEmbalCore;
using ToutEmbalCore.Producers;

namespace ToutEmbalUI.Libs
{
    public class ManagerStatus
    {
        public IManager Manager { get; init; }
        public ToolStripStatusLabel Label { get; init; }

        public ManagerStatus(
            IManager manager,
            ToolStripStatusLabel label
        )
        {
            Manager = manager;
            Label = label;

            Manager.GetUnit().OnStateChanged += UpdateStatusInfoEvent;
            UpdateStatusInfoEvent(this, EventArgs.Empty);
        }

        public void UpdateStatusInfoEvent(object? sender, EventArgs e)
        {
            string stateMessage = Manager
                .GetUnit()
                .GetState()
                .GetName()
            ;

            Label.Text = $"Caisse {Manager.GetUnit().GetName()}: {stateMessage}";
        }
    }
}

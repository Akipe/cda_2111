using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToutEmbalCore;

namespace ToutEmbalUI.Libs
{
    public class ManagerStatus
    {
        public ProducerManager Manager { get; init; }
        public ToolStripStatusLabel Label { get; init; }

        public ManagerStatus(
            ProducerManager manager,
            ToolStripStatusLabel label
        )
        {
            Manager = manager;
            Label = label;

            Manager.Unit.OnStateChanged += UpdateStatusInfoEvent;
            UpdateStatusInfoEvent(this, EventArgs.Empty);
        }

        public void UpdateStatusInfoEvent(object? sender, EventArgs e)
        {
            string valueState = string.Empty;

            switch (Manager.Unit.GetState())
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

            Label.Text = $"Caisse {Manager.Unit.GetName()}: {valueState}";
        }
    }
}

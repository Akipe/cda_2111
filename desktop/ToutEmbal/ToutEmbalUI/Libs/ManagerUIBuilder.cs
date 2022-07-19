using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToutEmbalCore;

namespace ToutEmbalUI.Libs
{
    public class ManagerUIBuilder
    {
        public static List<ProducerManager>? Managers { get; private set; }

        public ProducerManager? Manager { get; private set; }
        public ManagerStatus? Status { get; private set; }
        public ManagerSpecs? Specs { get; private set; }
        public ManagerLoading? Loading { get; private set; }
        public ManagerCommand? Command { get; private set; }

        public ManagerUIBuilder(ProducerManager manager)
        {
            AddManager(manager);
        }

        public ManagerUIBuilder AddManager(ProducerManager manager)
        {
            Manager = manager;

            if (Managers is null)
            {
                Managers = new List<ProducerManager>();
            }
            Managers.Add(manager);

            return this;
        }

        public ManagerUIBuilder AddStatus(ToolStripStatusLabel label)
        {
            if (Manager is null)
                throw new MemberAccessException("You need a manager");

            Status = new ManagerStatus(Manager, label);

            return this;
        }

        public ManagerUIBuilder AddSpecs(ManagerSpecs specs)
        {
            if (Manager is null)
                throw new MemberAccessException("You need a manager");

            Specs = specs;
            specs.Manager = Manager;

            return this;
        }

        public ManagerUIBuilder AddLoading(ManagerLoading loading)
        {
            if (Manager is null)
                throw new MemberAccessException("You need a manager");

            Loading = loading;
            loading.Manager = Manager;

            return this;
        }

        private void InitButtonIfNeeded()
        {
            if (Manager is null)
                throw new MemberAccessException("You need a manager");

            if (Command is null)
            {
                Command = new ManagerCommand(Manager);
            }
        }

        public ManagerUIBuilder AddLaunchButtons(object[] btns)
        {
            InitButtonIfNeeded();

            foreach (object btn in btns)
            {
                Command.BindLaunch(btn);
            }

            return this;
        }

        public ManagerUIBuilder AddStopButtons(object[] btns)
        {
            InitButtonIfNeeded();

            foreach (object btn in btns)
            {
                Command.BindStop(btn);
            }

            return this;
        }

        public ManagerUIBuilder AddStartButtons(object[] btns)
        {
            InitButtonIfNeeded();

            foreach (object btn in btns)
            {
                Command.BindStart(btn);
            }

            return this;
        }
    }
}

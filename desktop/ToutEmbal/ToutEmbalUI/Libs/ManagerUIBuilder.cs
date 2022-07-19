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
        public static List<IManager>? Managers { get; private set; }

        public IManager? Manager { get; private set; }
        public ManagerStatus? Status { get; private set; }
        public ProductionStats? Specs { get; private set; }
        public ProductionProgress? Loading { get; private set; }
        public ManagerCommand? Command { get; private set; }

        public ManagerUIBuilder(IManager manager)
        {
            AddManager(manager);
        }

        public ManagerUIBuilder AddManager(IManager manager)
        {
            Manager = manager;

            if (Managers is null)
            {
                Managers = new List<IManager>();
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

        public ManagerUIBuilder AddSpecs(ProductionStats specs)
        {
            if (Manager is null)
                throw new MemberAccessException("You need a manager");

            Specs = specs;
            specs.Manager = Manager;

            return this;
        }

        public ManagerUIBuilder AddLoading(ProductionProgress loading)
        {
            if (Manager is null)
                throw new MemberAccessException("You need a manager");

            Loading = loading;
            loading.Manager = Manager;

            return this;
        }

        private void GenerateCommandIfNeeded()
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
            GenerateCommandIfNeeded();

            foreach (object btn in btns)
            {
                Command.BindLaunch(btn);
            }

            return this;
        }

        public ManagerUIBuilder AddStopButtons(object[] btns)
        {
            GenerateCommandIfNeeded();

            foreach (object btn in btns)
            {
                Command.BindStop(btn);
            }

            return this;
        }

        public ManagerUIBuilder AddStartButtons(object[] btns)
        {
            GenerateCommandIfNeeded();

            foreach (object btn in btns)
            {
                Command.BindStart(btn);
            }

            return this;
        }
    }
}

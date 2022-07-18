using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToutEmbalCore;

namespace ToutEmbalUI
{
    public class ManagerUIBuilder
    {
        public static List<ProducerManager>? Managers { get; private set; }

        public ProducerManager? Manager { get; private set; }
        public Form? CurrentForm { get; private set; }
        public ManagerStatus? Status { get; private set; }
        public ManagerSpecs? Specs { get; private set; }
        public ManagerLoading? Loading { get; private set; }
        public ManagerButton? Button { get; private set; }

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

        public ManagerUIBuilder AddForm(Form form)
        {
            CurrentForm = form;

            return this;
        }

        private void AddButton()
        {
            if (Manager is null)
                throw new MemberAccessException("You need a manager");
            if (CurrentForm is null)
                throw new MemberAccessException("You need a form");

            if (Button is null)
            {
                Button = new ManagerButton(CurrentForm, Manager);
            }
        }

        public ManagerUIBuilder AddLaunchButtons(object[] btns)
        {
            AddButton();

            foreach (object btn in btns)
            {
                Button.BindLaunch(btn);
            }

            return this;
        }

        public ManagerUIBuilder AddStopButtons(object[] btns)
        {
            AddButton();

            foreach (object btn in btns)
            {
                Button.BindStop(btn);
            }

            return this;
        }

        public ManagerUIBuilder AddStartButtons(object[] btns)
        {
            AddButton();

            foreach (object btn in btns)
            {
                Button.BindStart(btn);
            }

            return this;
        }
    }
}

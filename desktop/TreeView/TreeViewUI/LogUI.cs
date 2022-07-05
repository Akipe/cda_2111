using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewUI
{
    internal class LogUI
    {
        Form form;
        ToolStripStatusLabel LogControl;

        public LogUI(
            Form form,
            ToolStripStatusLabel logControl
        )
        {
            this.form = form;
            LogControl = logControl;
        }

        public void Msg(string message)
        {
            form.Text = message;
            LogControl.Text = message;
        }
    }
}


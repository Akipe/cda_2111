using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewUI
{
    internal class LogUI
    {
        ToolStripStatusLabel LogControl;

        public LogUI(ToolStripStatusLabel logControl)
        {
            LogControl = logControl;
        }

        public void Msg(string message)
        {
            LogControl.Text = message;
        }
    }
}


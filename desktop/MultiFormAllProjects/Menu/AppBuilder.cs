using _01_MagicButton;
using _02_simple_addition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    public class AppBuilder<T> where T:Form, new()
    {
        private int Index { get; set; }
        private Form MdiParent { get; set; }

        public AppBuilder()
        {
            Index = 0;
        }

        public T Create(Form mdiParent)
        {
            T form = new T();
            form.Text += $" N° {++Index}";
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.WindowState = FormWindowState.Maximized;
            //form.FormClosing += App_Closing;
            form.MdiParent = mdiParent;

            return form;
        }
    }
}

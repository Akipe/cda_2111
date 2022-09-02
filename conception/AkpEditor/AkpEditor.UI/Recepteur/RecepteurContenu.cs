using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkpEditor.UI.Recepteur
{
    public partial class RecepteurContenu : UserControl
    {
        public RecepteurContenu()
        {
            InitializeComponent();

            textBox.Text = "Voici un texte d'exemple pour la présentation :) .";
        }

        public TextBox GetControl()
        {
            return textBox;
        }
    }
}

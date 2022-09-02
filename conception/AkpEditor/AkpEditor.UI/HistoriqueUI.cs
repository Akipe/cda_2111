using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkpEditor.UI
{
    public partial class HistoriqueUI : Form
    {
        public HistoriqueUI()
        {
            InitializeComponent();
        }

        public void SetHistorique(List<string> liste)
        {
            lbHistorique.DataSource = liste;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkpEditor.UI
{
    public interface ICommande
    {
        void Executer();
        void Annuler();
        string Description();
    }
}

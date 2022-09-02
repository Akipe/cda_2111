using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMemento.UML.AvecCommande
{
    public interface ICommande
    {
        void Executer();
        // Pas besoin d'annuler
        // void Annuler();
    }
}

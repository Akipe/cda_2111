using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExempleConcret
{
    public class Joueur
    {
        public int PositionX { get; set; }
        public Label Representation { get; set; }

        public Joueur(Label representation)
        {
            Representation = representation;
            PositionX = 0;
        }

        public void Droite()
        {
            PositionX += 1;
        }

        public void Gauche()
        {
            PositionX -= 1;
        }
    }
}

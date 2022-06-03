using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ScrollColorChoose
{
    public class ColorChooser
    {
        public const byte MIN_COLOR_LEVEL = 0;
        public const byte MAX_COLOR_LEVEL = 255;

        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }

        public ColorChooser()
        {
            Red = 0;
            Green = 0;
            Blue = 0;
        }

        public Color GetFinalColor()
        {
            return Color.FromArgb(Red, Green, Blue);
        }
    }
}

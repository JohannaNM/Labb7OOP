using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7OOP
{
    internal class Ellips : Geometri
    {
        public double HalvAxelX { get; set; }
        public double HalvAxelY { get; set; }

        public Ellips()
        {
            HalvAxelX = 3;
            HalvAxelY = 7;
        }

        public override double Area()
        {
            return Math.PI * HalvAxelX * HalvAxelY;
        }

       
    }
}

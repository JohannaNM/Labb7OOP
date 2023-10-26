using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7OOP
{
    internal class Parallellogram : Geometri
    {
        public double Bredd { get; set; }
        public double Höjd { get; set; }

        public Parallellogram()
        {
            Bredd = 6;
            Höjd = 12;
        }
        public override double Area()
        {
            return Bredd * Höjd;
        }

   
    }
}

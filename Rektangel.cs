using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7OOP
{
    internal class Rektangel : Geometri
    {
        public double Bredd { get; set; }
        public double Höjd { get; set; }

        public Rektangel()
        {
            Bredd = 8;
            Höjd = 10;
        }
        public override double Area()
        {
            return Bredd * Höjd;
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7OOP
{
    internal class Cirkel : Geometri
    {
        public double Radie { get; set; }

        public Cirkel()
        {
            Radie = 4;
        }
        public override double Area()
        {

            return Radie * Radie * Math.PI;
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7OOP
{
    internal class Fyrkant : Geometri
    {
        public double Sida { get; set; }

        public Fyrkant()
        {
            Sida = 5;
        }
        public override double Area()
        {
            return Sida * Sida;
        }

       
    }
}

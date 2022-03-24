using System;
using System.Collections.Generic;
using System.Text;

namespace casding.Models
{
    class Celsius
    {
        public double Degre { get; set; }

        public Celsius(double degre)
        {
            Degre = degre;
        }
        public static implicit operator Kelvin(Celsius n)
        {
            return new Kelvin(n.Degre + 273);
        }
    }



}

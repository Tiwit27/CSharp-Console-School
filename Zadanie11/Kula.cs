using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie11
{
    internal class Kula : Figury
    {
        private double r;
        public Kula(double r) 
        {
            this.r = r;
        }
        public double Objetosc()
        {
            return ((4.0 / 3.0) * Math.PI * Math.Pow(r, 3));
        }

        public double PolePowierzchni()
        {
            return 4 * Math.PI * Math.Pow(r, 2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie11
{
    internal class Walec : Figury
    {
        private double r, h;
        public Walec(double r, double h)
        {
            this.r = r;
            this.h = h;
        }
        public double Objetosc()
        {
            return Math.PI * Math.Pow(r, 2) * h;
        }

        public double PolePowierzchni()
        {
            return (2 * Math.PI * r * h) + (2 * Math.PI * Math.Pow(r, 2));
        }
    }
}

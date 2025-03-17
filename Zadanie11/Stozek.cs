using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie11
{
    internal class Stozek : Figury
    {
        private double r, h;
        public Stozek(double r, double h)
        {
            this.r = r;
            this.h = h;
        }
        public double Objetosc()
        {
            return (1.0 / 3.0) * h * Math.PI * Math.Pow(r, 2);
        }

        public double PolePowierzchni()
        {
            double l = Math.Sqrt(Math.Pow(r, 2) + Math.Pow(h, 2));
            return Math.PI * Math.Pow(r, 2) + Math.PI * r * l;
        }
    }
}

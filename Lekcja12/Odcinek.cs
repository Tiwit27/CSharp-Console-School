using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja12
{
    internal class Odcinek
    {
        public Punkt poczatek;
        public Punkt koniec;

        public Odcinek(Punkt punktA, Punkt punktB)
        {
            poczatek = punktA;
            koniec = punktB;
        }

        public double DlugoscOdcinka()
        {
            return Math.Sqrt(Math.Pow(poczatek.X - koniec.X, 2) + Math.Pow(poczatek.Y - koniec.Y, 2));
        }
    }
}

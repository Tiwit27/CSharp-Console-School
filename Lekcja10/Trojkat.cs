using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja10
{
    internal class Trojkat
    {
        double[] boki = new double[3];
        internal double[] Boki
        {
            get { return boki; }
            set 
            {
                if (CzyTrojkatIstnieje(value))
                {
                    Console.WriteLine("Trójkąt powstał");
                    boki = value;
                }
                else
                {
                    boki = new double[] { 0, 0, 0 };
                }
            }
        }
        internal double Pole()
        {
            var s = Obwod() / 2;
            return Math.Round(Math.Sqrt(s * (s - boki[0]) * (s - boki[1]) * (s - boki[2])),2);
        }
        internal double Obwod()
        {
            return boki[0] + boki[1] + boki[2];
        }
        internal bool CzyJestProstokatny()
        {
            var temp = boki.OrderBy(x => x).ToList();
            if (Math.Pow(temp[0], 2) + Math.Pow(temp[1], 2) == Math.Pow(temp[2], 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        internal bool CzyJestRozwartokatny()
        {
            var temp = boki.OrderBy(x => x).ToList();
            if (Math.Pow(temp[0], 2) + Math.Pow(temp[1], 2) < Math.Pow(temp[2], 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        internal bool CzyJestOstrokatny()
        {
            var temp = boki.OrderBy(x => x).ToList();
            if (Math.Pow(temp[0], 2) + Math.Pow(temp[1], 2) > Math.Pow(temp[2], 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        internal bool CzyTrojkatIstnieje(double[] boki)
        {
            var temp = boki.OrderBy(x => x).ToList();
            if (temp[0] >= 0)
            {
                if (temp[0] + temp[1] > temp[2])
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Nie można zbudować trójkąta z podanych długości boków");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Długości boków nie mogą być ujemne");
                return false;
            }
        }
        internal void WyswietlDane()
        {
            if (boki[0] != 0)
            {
                string rodzajTrojkata;
                if (CzyJestOstrokatny())
                {
                    rodzajTrojkata = "Ostrokątny";
                }
                else if (CzyJestProstokatny())
                {
                    rodzajTrojkata = "Prostokątny";
                }
                else
                {
                    rodzajTrojkata = "Rozwartokątny";
                }
                Console.WriteLine("Dane o trójkącie:" +
                    "\nBok 1: " + boki[0] +
                    "\nBok 2: " + boki[1] +
                    "\nBok 3: " + boki[2] +
                    "\nPole: " + Pole() +
                    "\nObwód: " + Obwod() +
                    "\nRodzaj trójkąta: " + rodzajTrojkata);
            }
        }
    }
}

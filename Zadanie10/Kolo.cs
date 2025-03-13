using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie10
{
    internal class Kolo : Figura
    {
        double r;
        public Kolo(double r)
        {
            this.r = r;
        }
        public override double Obwod()
        {
            return (2 * Math.PI * r);
        }

        public override double Pole()
        {
            return (Math.PI * Math.Pow(r, 2));
        }

        public override void WyswietlBoki()
        {
            Console.WriteLine($"Koło o promieniu: {r}");
        }
    }
}

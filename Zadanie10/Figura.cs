using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie10
{
    abstract internal class Figura
    {
        abstract public double Pole();
        abstract public double Obwod();
        abstract public void WyswietlBoki();
        public void WyswietlTyp()
        {
            Console.WriteLine("Figura jest typu: " + GetType().Name);
        }
    }
}

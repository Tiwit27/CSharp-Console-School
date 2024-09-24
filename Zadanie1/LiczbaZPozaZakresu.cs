using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class LiczbaZPozaZakresu : Exception
    {
        public LiczbaZPozaZakresu(string komunikat)
        {
            Console.WriteLine(komunikat);
        }
    }
}

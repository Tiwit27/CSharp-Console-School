using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja4
{
    internal class LiczbaZPozaZakresu : Exception
    {
        public LiczbaZPozaZakresu(string komunikatBledu)
        {
            Console.WriteLine(komunikatBledu);
        }
    }
}

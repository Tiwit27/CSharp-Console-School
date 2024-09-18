using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja3
{
    internal class NiewlasciwyWiek : Exception
    {
        public NiewlasciwyWiek(string komunikat)
        {
            Console.WriteLine(komunikat);
        }
    }
}

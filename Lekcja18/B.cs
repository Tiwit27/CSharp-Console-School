using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja18
{
    internal class B: A
    {
        private string polePrywatneB = "polePrywatneB";
        public string polePubliczneB = "polePubliczneB";

        public void MetodaB()
        {
            Console.WriteLine($"{polePrywatneB} {polePubliczneB} {poleProtected} {poleInternal}");
        }
    }
}

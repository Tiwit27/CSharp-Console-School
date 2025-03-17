using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja23
{
    internal class Pies : Zwierze
    {
        public void DajGlos()
        {
            Console.WriteLine("głos: hau hau hau");
        }

        public void Pozywienie()
        {
            Console.WriteLine("pokarm: mięso, psia karma");
        }
    }
}

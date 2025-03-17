using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja23
{
    internal class Krowa : Zwierze
    {
        public void DajGlos()
        {
            Console.WriteLine("głos: muuu muu");
        }

        public void Pozywienie()
        {
            Console.WriteLine("pokarm: trawa");
        }
    }
}

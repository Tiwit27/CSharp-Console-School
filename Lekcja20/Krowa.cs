using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja20
{
    internal class Krowa:Zwierze
    {
        public void DajGlos()
        {
            Console.WriteLine("głos: muuuuuu");
        }

        public void Pokarm()
        {
            Console.WriteLine("pokarm: trawa");
        }

        public void Pozytek()
        {
            Console.WriteLine("pożytek: mleko");
        }
    }
}

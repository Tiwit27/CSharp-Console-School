using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja20
{
    internal class Krowa:Zwierze
    {
        override public void DajGlos()
        {
            Console.WriteLine("głos: muuuuuu");
        }

        override public void Pokarm()
        {
            Console.WriteLine("pokarm: trawa");
        }

        override public void Pozytek()
        {
            Console.WriteLine("pożytek: mleko");
        }
    }
}

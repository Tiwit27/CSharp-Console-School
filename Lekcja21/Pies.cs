using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja20
{
    internal class Pies:Zwierze
    {
        override public void DajGlos()
        {
            Console.WriteLine("głos: hau hau");
        }

        override public void Pokarm()
        {
            Console.WriteLine("pokarm: mięso, karma");
        }

        override public void Pozytek()
        {
            Console.WriteLine("pożytek: pilnuje domu");
        }
    }
}

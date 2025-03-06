using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja20
{
    internal class Pies:Zwierze
    {
        public void DajGlos()
        {
            Console.WriteLine("głos: hau hau");
        }

        public void Pokarm()
        {
            Console.WriteLine("pokarm: mięso, karma");
        }

        public void Pozytek()
        {
            Console.WriteLine("pożytek: pilnuje domu");
        }
    }
}

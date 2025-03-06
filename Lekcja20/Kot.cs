using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja20
{
    internal class Kot : Zwierze
    {
        new public void DajGlos()
        {
            Console.WriteLine("głos: miau miau");
        }

        public void Pokarm()
        {
            Console.WriteLine("pokarm: wodzisławski kryształ");
        }

        public void Pozytek()
        {
            Console.WriteLine("pożytek: tępi szkodniki");
        }
    }
}

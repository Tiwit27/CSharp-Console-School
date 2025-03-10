using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja20
{
    internal class Kot : Zwierze
    {
        override public void DajGlos()
        {
            Console.WriteLine("głos: miau miau");
        }

        override public void Pokarm()
        {
            Console.WriteLine("pokarm: karma");
        }

        override public void Pozytek()
        {
            Console.WriteLine("pożytek: tępi szkodniki");
        }

        public void OKocie()
        {
            Console.WriteLine("Koty chodzą własnymi drogami");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja23
{
    internal class Kot : Zwierze
    {
        public void DajGlos()
        {
            Console.WriteLine("głos: miau miau miau");
        }

        public void Pozywienie()
        {
            Console.WriteLine("pokarm: kocia karma, mleko");
        }
    }
}

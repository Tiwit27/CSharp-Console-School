using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja20
{
    internal class Zwierze
    {
        virtual public void DajGlos()
        {
            Console.WriteLine("głos ?");
        }

        virtual public void Pokarm()
        {
            Console.WriteLine("pokarm ?");
        }

        virtual public void Pozytek()
        {
            Console.WriteLine("pożytek ?");
        }
    }
}

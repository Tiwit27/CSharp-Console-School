using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja22
{
    internal class Krowa : Zwierzeta
    {
        public override void DajGlos()
        {
            Console.WriteLine("Krowa robi muuuu");
        }

        public override void Pokarm()
        {
            Console.WriteLine("Krowa je trawę");
        }

        public override void Pozytek()
        {
            Console.WriteLine("Krowa daje mleko");
        }
    }
}

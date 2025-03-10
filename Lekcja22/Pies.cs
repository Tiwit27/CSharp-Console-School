using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja22
{
    internal class Pies : Zwierzeta
    {
        public override void DajGlos()
        {
            Console.WriteLine("Pies robi hau hau");
        }

        public override void Pokarm()
        {
            Console.WriteLine("Pies je karmę");
        }

        public override void Pozytek()
        {
            Console.WriteLine("Pies pilnuje domu");
        }

        public override void PokazTypZwierzecia()
        {
            base.PokazTypZwierzecia();
            Console.WriteLine("Pies jest przyjacielem człowieka");
        }
    }
}

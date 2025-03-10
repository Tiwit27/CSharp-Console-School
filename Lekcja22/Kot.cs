using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja22
{
    internal class Kot : Zwierzeta
    {
        public override void DajGlos()
        {
            Console.WriteLine("Kot robi miau");
        }

        public override void Pokarm()
        {
            Console.WriteLine("Kot je karmę");
        }

        public override void Pozytek()
        {
            Console.WriteLine("Kot łapie myszy");
        }

        public void OKocie()
        {
            Console.WriteLine("Koty chodzą swoimi drogami");
        }
    }
}

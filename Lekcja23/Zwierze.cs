using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja23
{
    internal interface Zwierze
    {
        public void DajGlos();
        public void Pozywienie();

        public void KimJestem()
        {
            Console.WriteLine("Jestem zwierzęciem typu: " + GetType().Name);
        }
    }
}

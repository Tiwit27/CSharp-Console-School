using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja22
{
    abstract internal class Zwierzeta : Zwierzeta2
    {
        abstract public void DajGlos();
        abstract public void Pokarm();
        virtual public void PokazTypZwierzecia()
        {
            Console.WriteLine("Jestem zwierzęciem typu: " + GetType().Name);
        }
    }
}

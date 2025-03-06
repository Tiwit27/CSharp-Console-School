using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja18
{
    public class A
    {
        private string polePrivate = "pole prywatne";
        public string polePublic = "pole publiczne";
        internal string poleInternal= "pole internal";
        protected string poleProtected = "pole Protected";

        private void MetodaPrivate()
        {
            Console.WriteLine("pole prywatne");
        }
        public void MetodaPublic()
        {
            Console.WriteLine("pole publiczne");
        }
        internal void MetodaInternal()
        {
            Console.WriteLine("pole internal");
        }
        protected void MetodaProtected()
        {
            Console.WriteLine("pole Protected");
        }

        public void Metoda()
        {
            Console.WriteLine($"{polePrivate} {poleProtected} {poleInternal} {polePublic}");
            MetodaPrivate();
            MetodaPublic();
            MetodaInternal();
            MetodaProtected();
        }
    }
}

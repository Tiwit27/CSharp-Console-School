using System.ComponentModel.DataAnnotations;

namespace Lekcja18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var A = new A();
            Console.WriteLine(A.poleInternal);
            Console.WriteLine(A.polePublic);
            A.MetodaInternal();
            A.MetodaPublic();
            A.Metoda();
            Console.WriteLine("");
            var B = new B();
            B.MetodaB();
        }
    }
}

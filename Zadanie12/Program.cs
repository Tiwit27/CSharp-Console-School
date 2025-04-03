using System.Runtime.Intrinsics.Arm;

namespace Zadanie12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    char wybor = 'z';
                    while(wybor != '1')
                    {
                        Console.Clear();
                        Console.WriteLine("---MENU---");
                        Console.WriteLine("----------");
                        Console.WriteLine("1. Graj");
                        Console.WriteLine("2. Zakończ");
                        Console.Write("Wybór: ");
                        wybor = Console.ReadKey().KeyChar;
                        if (wybor == '2')
                        {
                            Environment.Exit(0);
                        }
                    }
                    Totoloto.Podaj();
                    Totoloto.Losuj();
                    Totoloto.Wypisz();
                    Console.ReadKey();
                    wybor = 'z';
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

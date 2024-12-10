using System.Linq.Expressions;

namespace Zadanie8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisz program losowanie:
            //1. Dużego lotka 6/49 typujesz 6 liczb
            //2. Multi lotka 20/80 typujesz 10 liczb
            //Program wyświetla liczby do losowania, liczby typowane, liczby wylosowane oraz liczby trafione
            while (true)
            {
                try
                {
                    Console.WriteLine("MENU\n" +
                        "1. Duże Lotto\n" +
                        "2. Multi Lotto");
                    char wybor = Console.ReadKey().KeyChar;
                    switch(wybor)
                    {
                        case '1':
                            Lotto.Losowanie(49,6,6);
                            break;
                        case '2':
                            Lotto.Losowanie(80,20,10);
                            break;
                        default:
                            Console.Clear();
                            throw new Exception("Nie ma takigo wyboru");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}

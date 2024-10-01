using System.Threading.Channels;

namespace Lekcja5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Metoda statyczna to metoda, która należy do samej klasy, a nie do konkretnej instancji klasy.
            //Oznacza to, że możesz wywołać metodę statyczną bez wcześniejszego tworzenia obiektu klasy.
            //Metoda statyczna może uzyskać dostęp tylko do zmiennych statycznych i innych metod statycznych klasy, a nie do zmiennych lub metod instancji


            //Konwersja
            //double x;
            //Console.WriteLine("Podaj liczbę:");
            //x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(x);

            //Konwersja z sprawdzeniem przed
            int y;
            Console.WriteLine("Podaj liczbę całkowitą:");
            if (int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine(y + y);
            }
            else
            {
                Console.WriteLine("Błędne dane");
            }
            Console.WriteLine(Mata.Suma(2, 3));
        }
    }
}

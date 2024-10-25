using System.Security;

namespace Lekcja10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisz projekt trójkąty z osobną klasą trójkąt: 3 boki double (nie ujemne sprawdzone w setterze)(pola prywatne), metody: Pole , Obwód, CzyTrójkątIstnieje, czyJestProstokątny, czyJestRozwartokątny, CzyJestRozwartokątny. Obsługa błędów, program działa w pętli aż użytkownik zdecyduje o wyjściu. Wyświetl informacje o trójkącie
            List<Trojkat> trojkaty = new List<Trojkat>();
            while (true) 
            {
                trojkaty.Add(new Trojkat());
                var boki = new double[3];
                Console.WriteLine("Podaj bok a:");
                boki[0] = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj bok b:");
                boki[1] = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj bok c:");
                boki[2] = double.Parse(Console.ReadLine());
                trojkaty[0].Boki = boki;
                Console.Clear();
                trojkaty[0].WyswietlDane();
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

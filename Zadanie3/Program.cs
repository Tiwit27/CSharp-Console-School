using System.Security;

namespace Zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisz projekt trójkąty z osobną klasą trójkąt: 3 boki double (nie ujemne sprawdzone w setterze)(pola prywatne), metody: Pole , Obwód, CzyTrójkątIstnieje, czyJestProstokątny, czyJestRozwartokątny, CzyJestRozwartokątny. Obsługa błędów, program działa w pętli aż użytkownik zdecyduje o wyjściu. Wyświetl informacje o trójkącie
            List<Trojkat> trojkaty = new List<Trojkat>();
            while (true) 
            {
                try
                {
                    var actualEdited = new Trojkat();
                    trojkaty.Add(actualEdited);
                    var boki = new double[3];
                    Console.WriteLine("Podaj bok a:");
                    boki[0] = double.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj bok b:");
                    boki[1] = double.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj bok c:");
                    boki[2] = double.Parse(Console.ReadLine());
                    actualEdited.Boki = boki;
                    if (actualEdited.Boki[0] == 0) 
                    {
                        trojkaty.Remove(actualEdited);
                    }
                    else
                    {
                        Console.Clear();
                        actualEdited.WyswietlDane();
                    }
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Wybierz czy chcesz:\n" +
                        "1.kontynuować\n" +
                        "2.zakończyć.\n");
                    Console.Write("Podaj odpowiednią cyfrę: ");
                    if (Console.ReadKey().KeyChar == '2')
                    {
                        break;
                    }
                    Console.Clear();
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Błąd: " + ex.Message);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}

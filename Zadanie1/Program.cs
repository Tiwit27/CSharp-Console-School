namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Napisz program tabliczka mnożenia z obsługą błędów, użytkownik jest zmuszony do podania prawidłowych danych (liczby całkowite w przedziale od 0 do 10)*/
            do
            {
                try
                {
                    Console.WriteLine("Podaj liczbę a:");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj liczbę b:");
                    int b = Convert.ToInt32(Console.ReadLine());
                    if (a < 0 || a > 10 || b < 0 || b > 10)
                    {
                        throw new LiczbaZPozaZakresu("Błąd: liczba z poza zakresu");
                    }
                    int wynik = a * b;
                    Console.WriteLine($"Wynik: {a} * {b} = {wynik}");
                    Console.WriteLine("Wpisz:\n" +
                        "1. Aby kontynować\n" +
                        "2. Aby wyjść z programu");
                    int x = Convert.ToInt32(Console.ReadLine());
                    if (x != 1 && x != 2)
                    {
                        throw new LiczbaZPozaZakresu("Błąd: liczba z poza zakresu");
                    }
                    if (x == 2)
                    {
                        System.Environment.Exit(0);
                    }
                    Console.Clear();
                }
                catch (LiczbaZPozaZakresu e)
                {

                }
                catch (FormatException e)
                {
                    Console.WriteLine("Błąd typu danych: " + e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Błąd: " + e.Message);
                }

            } while (true);
        }
    }
}

namespace Lekcja4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wyjątki, część 2");
            int a;
            do
            {
                try
                {
                    Console.WriteLine("Podaj liczbę całkowitą z przedziału <0;9>");
                    a = Convert.ToInt32(Console.ReadLine());
                    if (a >= 0 && a <= 9)
                    {
                        break;
                    }
                    else
                    {
                        throw new LiczbaZPozaZakresu("Błąd: Liczba z poza zakresu <0;9>");
                    }
                }
                catch (LiczbaZPozaZakresu e)
                {

                }
                catch (FormatException e)
                {
                    Console.WriteLine("Błąd typu danych: " + e.Message);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("Błąd przekroczenia zakresu int: " + e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Błąd: " + e.Message);
                }
            } while (true);
            
        }
    }
}

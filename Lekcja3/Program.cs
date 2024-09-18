namespace Lekcja3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Obsługa wyjątków");

            
            //Console.WriteLine(double.MaxValue);
            //Console.WriteLine(double.MinValue);
            try
            {
                double a, b, c;
                Console.WriteLine("podaj liczbę a:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("podaj liczbę b:");
                b = Convert.ToInt32(Console.ReadLine());
                if(b == 0) 
                { 
                    throw new DivideByZeroException();
                }
                Console.WriteLine(a);
                Console.WriteLine(b);
                c = a / b;
                Console.WriteLine($"{a}/{b}={c}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Błąd dzielenia przez 0: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Błąd: " + ex.Message);
            }

            int wiek;
            try
            {
                Console.WriteLine("Podaj wiek: ");
                wiek = Convert.ToInt32(Console.ReadLine());
                if(wiek < 0 || wiek > 150) 
                {
                    throw new NiewlasciwyWiek("Wiek musi być w przedziale <0;150>");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Błąd: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}

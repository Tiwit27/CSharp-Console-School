namespace Zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    double x;
                    double y;
                    Punkt[] punkty = new Punkt[3];
                    Odcinek[] odcinki = new Odcinek[3];
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write("Podaj współrzędną x punktu " + Convert.ToChar(i + 65) + ":");
                        x = int.Parse(Console.ReadLine());
                        Console.Write("Podaj współrzędną y punktu " + Convert.ToChar(i + 65) + ":");
                        y = int.Parse(Console.ReadLine());
                        punkty[i] = new(x, y);
                    }
                    Trojkat trojkat = new(punkty[0], punkty[1], punkty[2]);
                    trojkat.Wypisz();
                    Console.ReadKey();
                    Console.Clear();
                    while(true)
                    {
                        Console.WriteLine("Menu:");
                        Console.WriteLine("1. Podaj kolejne wartości");
                        Console.WriteLine("2. Zakończ działanie programu");
                        Console.Write("Wybór: ");
                        char wybor = Console.ReadKey().KeyChar;
                        if (wybor == '2')
                        {
                            System.Environment.Exit(0);
                        }
                        else if (wybor == '1')
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Błędny wybor");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Błąd: " + e.Message);
                }
            }
        }
    }
}

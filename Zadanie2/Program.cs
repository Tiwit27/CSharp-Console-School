namespace Zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Napisz program który korzysta ze statycznych metod klasy matematyka
            metody: 
            1.Suma
            2.iloczyn
            3.iloraz
            4.potęga
            5.pierwiastek stopnia całkowitego
            6.silnia liczby naturalnej

            cały program działa w pętli(2 opcje: obliczaj i wyjście z programu)
            zastosuj obsługę błędów
            przy podaniu błędnych danych program ponownie prosi o podanie danych
            opcja wyboru
            */
            //Console.WriteLine(Math.Pow(-8, (1/3)));
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Wybierz opcje:");
                    Console.WriteLine("1.Suma \n2.Iloczyn \n3.Iloraz \n4.Potęga \n5.Pierwiastek \n6.Silnia \n7.Zakończ program");
                    int x = int.Parse(Console.ReadLine());
                    double a = 0, b = 0;
                    switch (x)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Podaj liczbę a:");
                            a = double.Parse(Console.ReadLine());
                            Console.WriteLine("Podaj liczbę b:");
                            b = double.Parse(Console.ReadLine());
                            Console.WriteLine($"{a} + {b} = {Matematyka.Suma(a, b)}");
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Podaj liczbę a:");
                            a = double.Parse(Console.ReadLine());
                            Console.WriteLine("Podaj liczbę b:");
                            b = double.Parse(Console.ReadLine());
                            Console.WriteLine($"{a} * {b} = {Matematyka.Iloczyn(a, b)}");
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Podaj liczbę a:");
                            a = double.Parse(Console.ReadLine());
                            Console.WriteLine("Podaj liczbę b:");
                            b = double.Parse(Console.ReadLine());
                            if(b == 0)
                            {
                                throw new MyException("Nie dziel przez 0");
                            }
                            Console.WriteLine($"{a} / {b} = {Matematyka.Iloraz(a, b)}");
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Podaj liczbę potęgowaną:");
                            a = double.Parse(Console.ReadLine());
                            Console.WriteLine("Podaj potęgę:");
                            b = double.Parse(Console.ReadLine());
                            Console.WriteLine($"{a}^{b} = {Matematyka.Potega(a, b)}");
                            Console.ReadKey();
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("Podaj liczbę pod pierwiastkiem:");
                            a = double.Parse(Console.ReadLine());
                            Console.WriteLine("Podaj stopień pierwiastka:");
                            b = double.Parse(Console.ReadLine());
                            if (a < 0 && b % 2 == 0)
                            {
                                throw new MyException("Dla podanych liczb nie ma wyniku");
                            }
                            Console.WriteLine($"pierwiastek {b} stopnia z {a} = {Matematyka.Pierwiastek(a, Convert.ToInt32(b))}");
                            Console.ReadKey();
                            break;
                        case 6:
                            Console.Clear();
                            Console.WriteLine("Podaj liczbę:");
                            a = double.Parse(Console.ReadLine());
                            if(a < 0 || (a - Convert.ToInt32(a)) != 0)
                            {
                                throw new MyException("Nie można obliczyć silni z podanej liczby");
                            }
                            Console.WriteLine($"{a}! = {Matematyka.Silnia(Convert.ToInt32(a))}");
                            Console.ReadKey();
                            break;
                        case 7:
                            System.Environment.Exit(0);
                            break;
                    }
                }
                catch (MyException e)
                {
                    Console.ReadKey();
                }
                catch (Exception e) 
                {
                    Console.WriteLine("Błąd: " + e.Message);
                    Console.ReadKey();
                }
            } while (true);
        }
    }
}

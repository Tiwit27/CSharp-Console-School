using KonwersjaCnaFiK;
using KonwersjaFnaCiK;
using KonwersjaKelwin;
namespace Lekcja8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Projekt składa się z 3 bibliotek.
            //Każda biblioteka zawiera klasę z metodą konwertującą:
            //1.temperatura w skali C na F i K
            //2.-||- F na C i K
            //3.-||- K na C i F
            //W programie głównym działającym w pętli mamy menu wyboru:
            //1.cel. na f. i kelvina
            //2. F na c i k
            //3. K na C i F
            //4.Wyjścvie z programu
            while (true)
            {
                try
                {
                    int wybor;
                    Console.WriteLine("MENU");
                    Console.WriteLine("------------");
                    Console.WriteLine("1. Konwertuj z C na F i K");
                    Console.WriteLine("2. Konwertuj z F na C i K");
                    Console.WriteLine("3. Konwertuj z K na F i C");
                    Console.WriteLine("4. Zakończ program");
                    wybor = int.Parse(Console.ReadLine());
                    Console.Clear();
                    while(true)
                    {
                        try
                        {
                            double temperatura;
                            double[] wynik;
                            switch (wybor)
                            {
                                case 1:
                                    Console.WriteLine("Podaj temperaturę w skali Celciusza:");
                                    temperatura = double.Parse(Console.ReadLine());
                                    if(temperatura < -273.15)
                                    {
                                        throw new MyException("Temperatura w stopniach Celcjusza nie może być niższa niż -273.15");
                                    }
                                    wynik = KonwerterRafal.CnaFiK(temperatura);
                                    Console.Clear();
                                    Console.WriteLine(temperatura + " Celcjusza to " + wynik[0] + " Fahrenheita");
                                    Console.WriteLine(temperatura + " Celcjusza to " + wynik[1] + " Kelwina");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                case 2:
                                    Console.WriteLine("Podaj temperaturę w skali Fahrenheita:");
                                    temperatura = double.Parse(Console.ReadLine());
                                    if (temperatura < -459.67)
                                    {
                                        throw new MyException("Temperatura w stopniach Fahrenheita nie może być niższa niż -459.67");
                                    }
                                    wynik = KonwenterJakub.FnaCiK(temperatura);
                                    Console.WriteLine(temperatura + " Fahrenheita to " + wynik[0] + " Celcjusza");
                                    Console.WriteLine(temperatura + " Fahrenheita to " + wynik[1] + " Kelwina");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                case 3:
                                    Console.WriteLine("Podaj temperaturę w skali Kelvina:");
                                    temperatura = double.Parse(Console.ReadLine());
                                    if (temperatura < 0)
                                    {
                                        throw new MyException("Temperatura w stopniach Kalwina nie może być niższa niż 0");
                                    }
                                    wynik = KonwerterTymoteusz.KnaC(temperatura);
                                    Console.WriteLine(temperatura + " Kelwiny to " + wynik[0] + " Celcjusza");
                                    Console.WriteLine(temperatura + " Kelwiny to " + wynik[1] + " Fahrenheita");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                case 4:
                                    System.Environment.Exit(0);
                                    break;
                                default:
                                    Console.WriteLine("Błędny wybór");
                                    break;
                            }
                            break;
                        }
                        catch(MyException e)
                        {
                            Console.ReadKey();
                            Console.Clear();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Błąd: " + e.Message);
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Błąd: " + e.Message);
                    Console.ReadLine();
                    Console.Clear();
                }

            }
        }
    }
}

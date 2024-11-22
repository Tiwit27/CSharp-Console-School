using System.Globalization;

namespace Zadanie7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    int[] PESEL = new int[11];
                    Console.WriteLine("Podaj swój PESEL: ");
                    string value = Console.ReadLine();
                    if(String.IsNullOrEmpty(value) || value.Length != 11)
                    {
                        throw new MyException("Błędny PESEL");
                    }    
                    for (int i = 0; i < PESEL.Length; i++)
                    {
                        PESEL[i] = value[i] - 48;
                    }
                    int dataUrodzenia = int.Parse(PESEL[4].ToString() + PESEL[5].ToString());
                    Console.WriteLine(dataUrodzenia);
                }
                catch (MyException)
                {
                    Console.ReadKey();
                    Console.Clear();
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

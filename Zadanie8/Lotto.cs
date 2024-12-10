using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie8
{
    internal class Lotto
    {
        public static void Losowanie(int max, int liczbaLosowanych, int liczbaTypowanych)
        {
            try
            {
                Console.Clear();
                int[] losowane = new int[max];
                for(int i = 0; i < losowane.Length; i++)
                {
                    losowane[i] = i + 1;
                }
                int[] wylosowane = new int[liczbaLosowanych];
                Random r = new();
                for(int i = 0; i < wylosowane.Length; i++)
                {
                    while(true)
                    {
                        int wylosowana = r.Next(1, losowane.Length);
                        if (!wylosowane.Contains(wylosowana))
                        {
                            wylosowane[i] = wylosowana;
                            break;
                        }
                    }
                }
                int[] wytypowane = new int[liczbaTypowanych];
                for (int i = 0; i < wytypowane.Length; i++)
                {
                    while(true)
                    {
                        Console.Write("Podaj kolejną liczbę do wytypowania: ");
                        int next = int.Parse(Console.ReadLine());
                        if (!wytypowane.Contains(next) && next > 0 && next <= losowane.Length)
                        {
                            wytypowane[i] = next;
                            break;
                        }
                        else if(next < 0 || next > losowane.Length)
                        {
                            Console.WriteLine("Liczba z poza zakresu");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Wytypowałeś już tą liczbę");
                            Console.ReadKey();
                        }
                        Console.Clear();
                    }
                    Console.Clear();
                }
                int[] trafione = wylosowane.Where(x => wytypowane.Contains(x)).ToArray();
                Console.WriteLine($"Liczby losowane: <{losowane[0]};{losowane[losowane.Length - 1]}>\n" +
                    $"Liczby wytypowane przez gracza: {String.Join(',', wytypowane)}\n" +
                    $"Liczby wylosowane przez maszynę losującą: {String.Join(',', wylosowane)}\n" +
                    $"Liczby trafione ({trafione.Length}): {String.Join(',', trafione)}");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}

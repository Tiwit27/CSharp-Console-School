using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie12
{
    internal class Totoloto
    {
        static string path = "wyniki.txt";
        static List<int> podane = new();
        static List<int> wylosowane = new();

        static void ZapisDoPliku()
        {
            if(!File.Exists(path))
            {
                File.Create(path);
            }
            var date = DateTime.Now;
            File.AppendAllText(path, "LOSOWANIE\n");
            File.AppendAllText(path, $"Data losowania: {date.Hour}:{date.Minute}:{date.Second} {date.Day}.{date.Month + 1}.{date.Year}\n");
            File.AppendAllText(path, "---------------------------------------------------------------\n");
            File.AppendAllText(path, $"Podane liczby: {String.Join(',', podane)}\n");
            File.AppendAllText(path, $"Wylosowane liczby: {String.Join(',', wylosowane)}\n");
            File.AppendAllText(path, $"Trafiono: {Trafione()} liczb\n");
            File.AppendAllText(path, "\n\n");
        }
        public static void Losuj()
        {
            while(wylosowane.Count < 6)
            {
                Random r = new();
                int wylosowana = r.Next(1, 50);
                if(wylosowane.Contains(wylosowana))
                {
                    continue;
                }
                wylosowane.Add(wylosowana);
            }
        }
        public static void Podaj()
        {
            while (podane.Count < 6)
            {
                try
                {
                    Console.Clear();
                    Console.Write("Podaj liczbę: ");
                    var liczba = int.Parse(Console.ReadLine());
                    if (podane.Contains(liczba))
                    {
                        throw new Exception("Podana liczba została już wcześniej wytypowana");
                    }
                    else if(liczba > 49 || liczba < 1)
                    {
                        throw new Exception("Podana liczba nie zawiera się w zakresie <1;49>");
                    }
                    podane.Add(liczba);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }
            }
        }
        static int Trafione()
        {
            int result = 0;
            for(int i = 0; i < 6; i++)
            {
                if (podane.Contains(wylosowane[i]))
                {
                    result++;
                }
            }
            return result;
        }
        public static void Wypisz()
        {
            Console.WriteLine("Podane liczby: " + String.Join(',', podane));
            Console.WriteLine("Wylosowane liczby: " + String.Join(',', wylosowane));
            ZapisDoPliku();
            Clear();
        }
        static void Clear()
        {
            podane.Clear();
            wylosowane.Clear();
        }
    }
}

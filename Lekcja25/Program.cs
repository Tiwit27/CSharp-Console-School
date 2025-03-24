using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace Lekcja25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odczyt całego pliku, po wcisnięciu przycisku");
            Console.ReadKey();
            StreamReader reader;
            string text;
            try
            {
                var sciezka = "pliki/plik.txt";
                //reader = new StreamReader(sciezka);
                //text = reader.ReadToEnd();
                //reader.Close();
                //Console.WriteLine(text);
                //Console.ReadKey();
                //Console.Clear();
                //Console.WriteLine("Odczyt jedną linijkę z pliku, po wcisnięciu przycisku");
                //Console.ReadKey();
                //Console.Clear();
                //sciezka = "../../../plik1.txt";
                //reader = new StreamReader(sciezka);
                //text = reader.ReadLine();
                //Console.WriteLine(text);
                //reader.Close();
                //Console.ReadKey();
                //Console.WriteLine("Odczyt linijek jedna po drugiej");
                //reader = new StreamReader(sciezka);
                //while(!reader.EndOfStream)
                //{
                //    Thread.Sleep(1);
                //    Console.WriteLine(reader.ReadLine());
                //}
                //reader.Close();
                //Console.ReadKey();
                //Console.Clear();
                //Console.WriteLine("Odczyt znaków jeden po drugim");
                //reader = new StreamReader(sciezka);
                //int x;
                //var random = new Random();
                //while ((x = reader.Read()) != -1)
                //{
                //    int liczbaKolor = random.Next(1, 16);
                //    Thread.Sleep(1);
                //    Console.ForegroundColor = (ConsoleColor)liczbaKolor;
                //    Console.Write((char)x);
                //}
                //reader.Close();
                //Console.Clear();
                //Console.ForegroundColor = ConsoleColor.White;
                sciezka = "pliki/liczby.txt";
                reader = new StreamReader(sciezka);
                Console.WriteLine("Liczby");
                var liczby = reader.ReadToEnd();
                var tablica = liczby.Split(new char[] {'\n', ' ', '\t'});
                foreach (var tab in tablica)
                {
                    Console.WriteLine($"Tablica: {tab}");
                }
                int[] tabLiczb = new int[tablica.Length];
                for (int i = 0; i < tablica.Length; i++)
                {
                    tabLiczb[i] = int.Parse(tablica[i]);
                }
                int suma = 0;
                foreach (var tab in tabLiczb)
                {
                    suma += tab;
                }
                Console.WriteLine(suma);
                var parzyste = new List<int>();
                var nieparzyste = new List<int>();
                foreach (var tab in tabLiczb)
                {
                    if(tab % 2 == 0)
                    {
                        parzyste.Add(tab);
                    }
                    else
                    {
                        nieparzyste.Add(tab);
                    }
                }
                foreach (var tab in nieparzyste)
                {
                    Console.WriteLine($"Nieparzyste: {tab}");
                }
                foreach (var tab in parzyste)
                {
                    Console.WriteLine($"Parzyste: {tab}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

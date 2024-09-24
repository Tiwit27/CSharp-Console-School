namespace Lekcja_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tablice
            int[] temperatury = new int[365];
            Random random = new Random();
            for (int i = 0; i < temperatury.Length; i++)
            {
                temperatury[i] = random.Next(-10, 35);
            }
            for (int i = 0; i < temperatury.Length; i++)
            {
                Console.Write(temperatury[i] + " ");
                if(i % 20 == 0)
                {
                    Console.WriteLine();
                }
            }
            foreach (var item in temperatury)
            {
                Console.WriteLine(item);
            }
            string[] dni_tygodnia = new string[7]{ "Poniedziałek", "Wtorek", "Środa", "Czwartek", "Piątek", "Sobota", "Niedziela" };
            foreach (var item in dni_tygodnia)
            {
                Console.WriteLine(item);
            }
            string[] dni_tygodnia1 = new string[]{ "Poniedziałek", "Wtorek", "Środa", "Czwartek", "Piątek", "Sobota", "Niedziela" };
            foreach (var item in dni_tygodnia1)
            {
                Console.WriteLine(item);
            }
            string[] dni_tygodnia2 = { "Poniedziałek", "Wtorek", "Środa", "Czwartek", "Piątek", "Sobota", "Niedziela" };
            foreach (var item in dni_tygodnia2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(dni_tygodnia[dni_tygodnia.Length - 1]);
            //tablice dwuwymiarowe
            Random losuj = new Random();
            int[,] temperatury2 = new int[7, 24];
            for (int i = 0; i < 7; i++)
            {
                for (int x = 0; x < 24; x++)
                {
                    temperatury2[i, x] = losuj.Next() % 40;
                }
            }
            for (int i = 0; i < 7; i++)
            {
                for (int x = 0; x < 24; x++)
                {
                    Console.Write(temperatury2[i,x] + " ");
                }
                Console.WriteLine();
            }
            int w = temperatury2.GetLength(0);
            int k = temperatury2.GetLength(1);
            int s = temperatury2.Length;
            Console.WriteLine(w);
            Console.WriteLine(k);
            Console.WriteLine(s);
            Console.WriteLine("============================================================================");
            int[,,] tablica3wymiarowa = new int[5, 6, 7];
            for (int i = 0; i < tablica3wymiarowa.GetLength(0); i++)
            {
                for (int y = 0; y < tablica3wymiarowa.GetLength(1); y++)
                {
                    for (int z = 0; z < tablica3wymiarowa.GetLength(2); z++)
                    {
                        tablica3wymiarowa[i, y, z] = losuj.Next() % 25;
                    }
                }
            }
            for (int i = 0; i < tablica3wymiarowa.GetLength(0); i++)
            {
                for (int y = 0; y < tablica3wymiarowa.GetLength(1); y++)
                {
                    for (int z = 0; z < tablica3wymiarowa.GetLength(2); z++)
                    {
                        Console.Write(tablica3wymiarowa[i,y,z] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

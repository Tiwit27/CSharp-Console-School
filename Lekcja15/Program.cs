namespace Lekcja_Tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Tablice 1 wymiarowe");
            Console.WriteLine();

            int[] liczbyCalkowite = new int[5];

            for (int i = 0; i < liczbyCalkowite.Length; i++)
            {
                Console.Write($"{liczbyCalkowite[i],4}");
            }

            Console.WriteLine();

            for (int i = 0; i < liczbyCalkowite.Length; i++)
            {
                liczbyCalkowite[i] = i * 10;
            }

            foreach (var liczba in liczbyCalkowite)
            {
                Console.Write($"{liczba,4}");
            }

            Console.WriteLine();

            string[] imiona = new string[3] { "Ala", "Ola", "Andrzej" };
            string[] nazwiska = new string[3] { "Adamski", "Święty", "Grażonka" };
            double[] liczbyRzeczywiste = { 1.5, 2.4, 5.6 };
            int[] temperatury = new int[365];


            int[] t4 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, };

            Console.WriteLine(t4.Sum());
            Console.WriteLine(t4.Max());
            Console.WriteLine(t4.Min());

            Console.ReadKey();

        }
    }
}
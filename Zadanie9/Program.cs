namespace Zadanie9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] t1 = new int[10];
            int[] t2 = new int[20];
            int[,,] t4 = new int[10, 10, 10];
            Metody.WypelnijTablice(t1);
            Metody.WyswietlTablice(t1);

            Metody.WypelnijTablice(t2);
            Metody.WyswietlTablice(t2);

            Console.WriteLine(t2.Contains(2));
            int[,] t3 = new int[3, 4];
            Metody.WypelnijTablice(t3);
            Metody.WyswietlTablice(t3);
            Metody.WypelnijTablice(t4);
            Metody.WyswietlTablice(t4);

            //tablica tablic
            int[][] t5 = new int[5][];
            for(int i = 0; i<t5.Length;i++)
            {
                t5[i] = new int[i + 1];
            }
            Random random = new Random();
            for (int i = 0; i<t5.Length;i++)
            {
                for(int j = 0; j<t5[i].Length;j++)
                {
                    t5[i][j] = random.Next(101);
                }
            }
            for(int i = 0;i<t5.Length;i++)
            {
                for(int j = 0;j < t5[i].Length;j++)
                {
                    Console.Write($"{t5[i][j], 4}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            foreach (var item in t5)
            {
                foreach (var item1 in item)
                {
                    Console.Write($"{item1,4}");
                }
                Console.WriteLine();
            }

            int[][] t6 =
            {
                [1,2,3],
                [4,5,6],
                [7],
                [8,9]
            };
            foreach (var item in t6)
            {
                foreach (var item1 in item)
                {
                    Console.Write($"{item1,4}");
                }
                Console.WriteLine();
            }
            Metody.WyswietlTablice(t6);
            int[][][] t7 =
            {
                [[1,2,3],[1,2,3]],
                [[1,2,3],[1,2,3]],
                [[1,2,3],[1,2,3]],
                [[1,2,3],[1,2,3]],
            };
            Metody.WyswietlTablice(t7);
        }
    }
}

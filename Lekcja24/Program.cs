using System.Collections;

namespace Lekcja24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lista1 = new List<string>();
            List<string> lista2 = ["Tomasz", "Adam", "Robert", "Jan"];
            ArrayList lista3 = [1,2,"Ola", "Ala", 4.6]; //W c# nie zalecane

            Wyswietl(lista2);

            List<int> lista4 = new();
            List<int> lista5 = [1,2,3,4];
            Wstaw(lista4, 10, 0, 50);
            lista4.Add(5);
            lista4.InsertRange(lista4.Count, lista5);
            lista4.RemoveAll(x => x > 2 && x < 5);
            WyswietlWLinii(lista4);
            Wyswietl(lista4);
            lista4.Add(5);
            Wyswietl(lista4);
            Console.WriteLine(lista4.Contains(5));
            Console.WriteLine(lista4.IndexOf(5));
            Console.WriteLine(lista2.FindIndex(item => item.Equals("Adam")));
            lista4.Sort();
            Wyswietl(lista4);
            lista4.Reverse();
            Wyswietl(lista4);
            Console.WriteLine(lista4.Average
                ());
        }
        static public void Wyswietl(List<string> collection)
        {
            foreach(var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
        }
        static public void Wyswietl(IList collection)
        {
            for(int i = 0; i < collection.Count; i++)
            {
                Console.WriteLine(collection[i]);
            }
            Console.WriteLine("");
        }
        static public void WyswietlWLinii(IList collection)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                Console.Write($"{collection[i], 4}");
            }
            Console.WriteLine("");
        }
        static public void Wstaw(List<int> list, int length, int min, int max)
        {
            var random = new Random();
            if(min > max)
            {
                var temp = max;
                max = min;
                min = temp;
            }
            for (int i = 0; i <= length; i++)
            {
                list.Add(random.Next(min, max + 1));
            }
        }
    }
}

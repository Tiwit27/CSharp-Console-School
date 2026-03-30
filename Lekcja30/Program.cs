namespace Lekcja30;

class Program
{
    static void Main(string[] args)
    {
        //Tablice jednowymiarowe
        /*int[] tab = new int[5];
        int[] tab2 = new int[]{1,5,3,4,6};
        Console.WriteLine(tab2.Length);
        try
        {
            tab2[7] = 5;
        }
        catch (IndexOutOfRangeException exception)
        {
            Console.WriteLine("Przkeroczony zakres tablicy " + exception.Message);
        }

        Wyswietl(tab2);*/
        
        
        int[] tab3 = new int[]{1,2,3,4,5,6,7};
        int[] tab4 = new int[]{1,2,3};
        int[] tab5 = tab4;
        Console.WriteLine(tab4 == tab3);
        Console.WriteLine(tab4.Equals(tab3));
        Console.WriteLine(tab4.SequenceEqual(tab3));
        Console.WriteLine(tab4.SequenceEqual(tab5));

        var result = Wyszukaj(tab4, 2);
        Console.WriteLine(result == null ? "Nie znaleziono tej liczby w podanej tablic" : "Liczba którą szukasz znajduje się na " +
            $"indeksie nr. {result}");

        Console.WriteLine(Array.Exists(tab3, x => x > 5));
        Console.WriteLine(Array.FindAll(tab3, x => x > 5).Length);
    }

    static void Wyswietl(int[] tab)
    {
        foreach (var i in tab)
        {
            Console.Write(i + " ");
        }
    }

    static int? Wyszukaj(int[] tab, int value)
    {
        var result = Array.IndexOf(tab, value);
        if (result == -1) return result;
        return result;
    }
}

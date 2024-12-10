namespace Lekcja16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 1, 5, 7, 89, 3, 2, 5 };
            int[] tab1 = { 5,4,7,4,8,21,3,5 };
            int[] tab2=new int[10];
            Tablica.WyswietlTablice(tab);
            Tablica.WyswietlTablice(tab1);
            Tablica.WypelnijTablice(tab2, tab2.Length);
        }
    }
}

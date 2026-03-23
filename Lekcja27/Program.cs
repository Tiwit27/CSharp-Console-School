namespace Lekcja27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            int y = 14;
            int z = x;

            //Console.WriteLine(x == z);
            //Console.WriteLine(x.Equals(y));
            //Console.WriteLine(x.Equals(z));

            Osoba o1 = new Osoba("Brzoza", "Ewa", 20);
            Osoba o2 = new Osoba("Brzoza", "Adam", 30);
            Osoba o3 = new Osoba("Brzoza", "Ewa", 20);
            Osoba o4 = o1;

            //Console.WriteLine(o1.Equals(o2));
            //Console.WriteLine(o1.Equals(o3));
            //Console.WriteLine(o2.Equals(o3));
            //Console.WriteLine(o1.Equals(o4));

            string imie1 = "Ala";
            string imie2 = "Ala";
            string imie3 = new string("Ala");
            Console.WriteLine(object.ReferenceEquals(imie1, imie3));
            Console.WriteLine(imie1 == imie3);
            Console.WriteLine(imie1.Equals(imie3));
        }
    }
}

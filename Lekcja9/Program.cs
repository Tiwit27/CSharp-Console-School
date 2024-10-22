namespace Lekcja9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod1 = new Samochod();
            Console.WriteLine("Podaj markę samochodu");
            samochod1.setMarka(Console.ReadLine());
            Console.WriteLine("Podaj typ silnika");
            samochod1.setSilnik(Console.ReadLine());
            Console.WriteLine("Podaj pojemnosc silnika");
            samochod1.setPojemnoscSilnika(double.Parse(Console.ReadLine()));
            Console.WriteLine("Podaj kolor");
            samochod1.setKolor(Console.ReadLine());
            Console.WriteLine("Podaj masę");
            samochod1.setMasa(int.Parse(Console.ReadLine()));
            Console.WriteLine("Podaj moc silnika");
            samochod1.setMoc(int.Parse(Console.ReadLine()));
            samochod1.WyswietDane();
        }
    }
}

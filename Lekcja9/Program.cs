namespace Lekcja9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod1 = new Samochod();
            Console.WriteLine("Podaj markę samochodu");
            samochod1.marka = Console.ReadLine();
            Console.WriteLine("Podaj silnik samochodu");
            samochod1.silnik = Console.ReadLine();
            Console.WriteLine("Podaj pojemność samochodu");
            samochod1.pojemnoscSilnika = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj kolor samochodu");
            samochod1.kolor = Console.ReadLine();
            Console.WriteLine("Podaj maksymalną prędkość samochodu");
            samochod1.maxPredkosc = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj masę samochodu");
            samochod1.masa = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj moc samochodu");
            samochod1.mocSilnika = double.Parse(Console.ReadLine());
            samochod1.WyswietDane();

            Samochod samochod2 = new Samochod();
            Console.WriteLine("Podaj markę samochodu");
            samochod2.marka = Console.ReadLine();
            Console.WriteLine("Podaj silnik samochodu");
            samochod2.silnik = Console.ReadLine();
            Console.WriteLine("Podaj pojemność samochodu");
            samochod2.pojemnoscSilnika = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj kolor samochodu");
            samochod2.kolor = Console.ReadLine();
            Console.WriteLine("Podaj maksymalną prędkość samochodu");
            samochod2.maxPredkosc = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj masę samochodu");
            samochod2.masa = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj moc samochodu");
            samochod2.mocSilnika = double.Parse(Console.ReadLine());
            samochod2.WyswietDane();

        }
    }
}

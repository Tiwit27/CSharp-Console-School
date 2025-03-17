namespace Zadanie11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var figury = new List<Figury>();
            figury.Add(new Kula(10));
            figury.Add(new Walec(10, 20));
            figury.Add(new Stozek(10,5));
            figury.Add(new Prostopadloscian(5,10,15));

            foreach(Figury f in figury)
            {
                f.TypFigury();
                Console.WriteLine("Objętość: " + Math.Round(f.Objetosc(), 2));
                Console.WriteLine("Pole Powierzchni: " + Math.Round(f.PolePowierzchni(), 2));
                Console.WriteLine("=========================\n");
            }
        }
    }
}

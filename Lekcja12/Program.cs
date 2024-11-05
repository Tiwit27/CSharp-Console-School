namespace Lekcja12
{
    internal class Program
    {
        //Punkt-Odcinek
        static void Main(string[] args)
        {
            Punkt punktA = new();
            Punkt punktB = new();

            Console.Write("Podaj współrzędną x punktu A: ");
            punktA.X = double.Parse(Console.ReadLine());
            Console.Write("Podaj współrzędną y punktu A: ");
            punktA.Y = double.Parse(Console.ReadLine());
            Console.Write("Podaj współrzędną x punktu B: ");
            punktB.X = double.Parse(Console.ReadLine());
            Console.Write("Podaj współrzędną y punktu B: ");
            punktB.Y = double.Parse(Console.ReadLine());

            Odcinek odcinek1 = new(punktA, punktB);
            Console.WriteLine(odcinek1.DlugoscOdcinka());
        }
    }
}

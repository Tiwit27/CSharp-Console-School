namespace Lekcja10
{
    internal class Program
    {
        //Temat: Gettery i Settery
        static void Main(string[] args)
        {
            Osoba osoba1 = new();
            osoba1.setNazwisko("Kowalski");
            Console.WriteLine(osoba1.getNazwisko());
            osoba1.Placa = 5000;
            Console.WriteLine(osoba1.Placa);
            osoba1.Imie = "Jan";
            Console.WriteLine(osoba1.Imie);
        }
    }
}

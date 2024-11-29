namespace Lekcja14
{
    internal class Program
    {
        //Dziedziczenie
        static void Main(string[] args)
        {
            Osoba osoba1 = new Osoba("Adam", "Danielski");

            Pracownik pracownik1 = new Pracownik("Marcin", "Nowak", "średnie", "spawacz");
            pracownik1.O_Pracowniku();
            Console.ReadKey();
        }
    }
}

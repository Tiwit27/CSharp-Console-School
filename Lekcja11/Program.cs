using System.Runtime.Versioning;

namespace Lekcja11
{
    internal class Program
    {
        //Konstruktory
        static void Main(string[] args)
        {
            Osoba os1 = new();
            os1.Nazwisko = "Kowalski";
            os1.Imie = "Adam";
            os1.Wizytowka();

            Osoba os2 = new("Kowalski");
            os2.Wizytowka();
            os2.Imie = "Kacper";

            Osoba os3 = new("Nowak", "Mateusz");
            os3.Wizytowka();
            
        }
    }
}

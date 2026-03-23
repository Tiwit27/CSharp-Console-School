namespace Lekcja28;

class Program
{
    static void Main(string[] args)
    {
        /*Zwierze pies1 = new Pies();
        Zwierze kot1 = new Kot();
        
        pies1.DajGlos();
        kot1.DajGlos();
        pies1.OZwierzetach();
        ((Pies)pies1).Pozytek();
        ((Kot)kot1).Pozytek();*/

        List<Zwierze> zwierzeta = new();
        zwierzeta.Add(new Pies());
        zwierzeta.Add(new Kot());
        zwierzeta.Add(new Pies());
        zwierzeta.Add(new Kot());
        foreach (var zwierze in zwierzeta)
        {
            zwierze.DajGlos();
            zwierze.KimJestem();
            zwierze.Pokarm();
            zwierze.OZwierzetach();
            zwierze.Pozytek();
            Console.WriteLine("--------------------------");
        }
    }
}

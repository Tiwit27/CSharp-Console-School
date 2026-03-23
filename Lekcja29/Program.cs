namespace Lekcja29;

class Program
{
    static void Main(string[] args)
    {
        List<Zwierze> zwierzeta = new();
        zwierzeta.Add(new Pies());
        zwierzeta.Add(new Kot());
        zwierzeta.Add(new Wilk());
        zwierzeta.Add(new Pies());
        zwierzeta.Add(new Kot());
        zwierzeta.Add(new Wilk());

        foreach (var zwierze in zwierzeta)
        {
            zwierze.DajGlos();
            zwierze.KimJestem();
            zwierze.Pokarm();
            zwierze.Pozytek();
            zwierze.CzyUdomowione();
        }
    }
}
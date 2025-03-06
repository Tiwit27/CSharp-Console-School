namespace Lekcja20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zwierzęta bez polimorfizmu");
            Zwierze zwierze1 = new Zwierze();
            Zwierze kot1 = new Kot();
            Zwierze pies1 = new Pies();
            Zwierze krowa1 = new Krowa();

            zwierze1.DajGlos();
            zwierze1.Pokarm();
            zwierze1.Pozytek();
            ((Kot)kot1).DajGlos();
            ((Kot)kot1).Pokarm();
            ((Kot)kot1).Pozytek();
            ((Pies)pies1).DajGlos();
            ((Pies)pies1).Pokarm();
            ((Pies)pies1).Pozytek();
            ((Krowa)krowa1).DajGlos();
            ((Krowa)krowa1).Pokarm();
            ((Krowa)krowa1).Pozytek();
            Informacja(krowa1);
            
            Console.WriteLine("---------------------------");

            List<Zwierze> zwierzeta = new List<Zwierze>();

            zwierzeta.Add(kot1);
            zwierzeta.Add(pies1);
            zwierzeta.Add(krowa1);
            zwierzeta.Add(new Kot());
            zwierzeta.Add(new Pies());
            zwierzeta.Add(new Krowa());

            foreach (var z in zwierzeta)
            {
                if(z.GetType() == typeof(Kot))
                {
                    Informacja((Kot)z);
                }
                else if (z is Pies)
                {
                    Informacja((Pies)z);
                }
                else if(z is Krowa)
                {
                    Informacja((Krowa)z);
                }
            }
        }

        static public void Informacja(Zwierze z)
        {
            Console.WriteLine($"Info o {z.GetType().Name}");
            z.DajGlos();
            z.Pokarm();
            z.Pozytek();
        }
    }
}

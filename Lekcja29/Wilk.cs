namespace Lekcja29;

public class Wilk : Zwierze
{
    public override void DajGlos()
    {
        Console.WriteLine("Auuu");
    }

    public override void Pokarm()
    {
        Console.WriteLine("Inne zwierzęta");
    }

    public override void Pozytek()
    {
        Console.WriteLine("Reguluje liczbę saren w lesie");
    }

    public override void CzyUdomowione()
    {
        Console.WriteLine("Jestem dzikim zwierzęciem");
    }
}
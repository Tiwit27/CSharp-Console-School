namespace Lekcja29;

public class Kot : Zwierze
{
    public override void DajGlos()
    {
        Console.WriteLine("Miau Miau");
    }

    public override void Pokarm()
    {
        Console.WriteLine("Kocia karma");
    }

    public override void Pozytek()
    {
        Console.WriteLine("Łowi myszy");
    }
}
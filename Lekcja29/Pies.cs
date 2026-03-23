namespace Lekcja29;

public class Pies : Zwierze
{
    public override void DajGlos()
    {
        Console.WriteLine("Hau Hau");
    }

    public override void Pokarm()
    {
        Console.WriteLine("Psia karma");
    }

    public override void Pozytek()
    {
        Console.WriteLine("Pilnuje domu");
    }
    
}
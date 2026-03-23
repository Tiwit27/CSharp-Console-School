namespace Lekcja28;

public class Pies : Zwierze
{
    override public void DajGlos()
    {
        Console.WriteLine("Hau Hau");
    }
    
    override public void Pokarm()
    {
        Console.WriteLine("Psia karma, mięso");
    }
    
    override public void KimJestem()
    {
        base.KimJestem();
        Console.WriteLine("Jestem psem");
    }

    override public void Pozytek()
    {
        Console.WriteLine("Pilnuje domu");
    }
}
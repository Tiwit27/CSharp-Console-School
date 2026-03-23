namespace Lekcja28;

public class Zwierze
{
    public virtual void DajGlos()
    {
        Console.WriteLine("Nie wiem jaki głos");
    }
    
    public virtual void Pokarm()
    {
        Console.WriteLine("Nie wiem jaki pokarm");
    }
    
    public virtual void KimJestem()
    {
        Console.WriteLine("Jestem zwierzęciem");
    }

    public void OZwierzetach()
    {
        Console.WriteLine("Bez świata zwierząt nie istniał by świat ludzi");
    }

    public virtual void Pozytek(){}
}
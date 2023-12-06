using AbstractFactory.Interfaces;

namespace AbstractFactory.Furnitures;

public class LuxuryChair : IChair
{
    public void SitOnIt()
    {
        Console.WriteLine("Tiens, ca c'est une chaise de grande qualité");
    }
}
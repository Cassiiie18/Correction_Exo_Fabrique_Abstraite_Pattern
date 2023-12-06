using AbstractFactory.Interfaces;

namespace AbstractFactory.Furnitures;

public class StandardChair : IChair
{
    public void SitOnIt()
    {
        Console.WriteLine("Tiens, ca c'est une chaise de moyenne qualité");
    }
}
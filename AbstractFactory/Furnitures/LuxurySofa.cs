using AbstractFactory.Interfaces;

namespace AbstractFactory.Furnitures;

public class LuxurySofa : ISofa
{
    public void SitOnIt()
    {
        Console.WriteLine("Tiens, ca c'est un sofa de grande qualité");
    }
}
using AbstractFactory.Interfaces;

namespace AbstractFactory.Furnitures;

public class StandardSofa : ISofa
{
    public void SitOnIt()
    {
        Console.WriteLine("Tiens, ca c'est un sofa de moyenne qualité");
    }
}
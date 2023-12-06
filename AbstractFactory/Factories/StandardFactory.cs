using AbstractFactory.Furnitures;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories;

public class StandardFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new StandardChair();
    }

    public ISofa CreateSofa()
    {
        return new StandardSofa();
    }
}
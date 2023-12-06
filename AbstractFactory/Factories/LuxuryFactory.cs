using AbstractFactory.Furnitures;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories;

public class LuxuryFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new LuxuryChair();
    }

    public ISofa CreateSofa()
    {
        return new LuxurySofa();
    }
}
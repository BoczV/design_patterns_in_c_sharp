using Singleton.And.Factory.Entities;
using Singleton.And.Factory.Factory;

namespace Singleton;

public static class Program
{
    static void Main()
    {
        Func<ShapeType, IShape> func = ShapeFactory.GetShape;

        ShapeType shapeType = ShapeType.Triangle;

        bool isSingleton = SingletonTester.IsSingleton(func, shapeType);

        Console.WriteLine(isSingleton ? $"{shapeType} is a singleton!" : $"{shapeType} is not a singleton!");
    }
}
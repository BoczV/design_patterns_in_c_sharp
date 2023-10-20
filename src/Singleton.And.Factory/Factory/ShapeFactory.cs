using Singleton.And.Factory.Entities;
using Singleton.And.Factory.Entities.Singleton;

namespace Singleton.And.Factory.Factory;

public static class ShapeFactory
{
    public static IShape GetShape(ShapeType shapeType)
    {
        IShape shape = null!;
        switch (shapeType)
        {
            case ShapeType.Circle:
                shape = Circle.GetInstance();
                break;
            case ShapeType.Square:
                shape = new Square();
                break;
            case ShapeType.Triangle:
                shape = new Triangle();
                break;
        }
        return shape ?? throw new NullReferenceException();
    }
}

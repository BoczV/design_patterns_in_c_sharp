using Singleton.And.Factory.Entities;
using Singleton.And.Factory.Entities.Singleton;

namespace Singleton.And.Factory.Factory;

public static class ShapeFactory
{
    public static IShape GetShape(ShapeType shapeType)
    {
        IShape shape = shapeType switch
        {
            ShapeType.Circle => Circle.GetInstance(),
            ShapeType.Square => new Square(),
            ShapeType.Triangle => new Triangle(),
            _ => throw new ArgumentException($"Unknown shape type: {shapeType}."),
        };
        return shape;
    }
}

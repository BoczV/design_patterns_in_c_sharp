using Singleton.And.Factory.Entities;
using Singleton.And.Factory.Factory;

namespace Singleton;

public static class SingletonTester
{
    public static bool IsSingleton(Func<ShapeType, IShape> func, ShapeType shapeType)
    {
        IShape shape = func(shapeType);
        int hashcode = shape.GetHashCode();
        for (int i = 0; i < 1000; i++)
        {
            IShape newShape = func(shapeType);
            int newHashCode = newShape.GetHashCode();
            if (hashcode != newHashCode)
            {
                return false;
            }
        }
        return true;
    }
}

namespace Singleton.And.Factory.Entities.Singleton;

public sealed class Circle : IShape
{

    private static readonly Lazy<Circle> _instance = new(() => new Circle("Circle"));
    public string Name { get; }

    private Circle(string name)
    {
        Name = name;
    }

    public static Circle GetInstance()
    {
        return _instance.Value;
    }

    public string Draw()
    {
        return $"I am the {Name}, one and allmighty singleton object! Bow before me! I draw a circle";
    }
}

namespace Singleton.And.Factory.Entities;

public class Triangle : IShape
{
    public string Name => "Triangle";

    public string Draw()
    {
        return $"I am a {Name} object! I draw a triangle.";
    }
}

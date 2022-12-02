namespace Singleton.And.Factory.Entities;

public class Square : IShape
{
    public string Name => "Square";

    public string Draw()
    {
        return $"I am a {Name} object! I draw a square.";
    }
}

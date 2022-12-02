namespace Prototype.Entities;

public class Point : IDeepCopyable<Point>
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Point DeepCopy()
    {
        return new Point(X, Y);
    }

    public override string? ToString()
    {
        return $"Point X: {X}, Y: {Y}";
    }
}

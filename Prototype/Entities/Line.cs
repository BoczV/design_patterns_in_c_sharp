namespace Prototype.Entities;

public class Line : IDeepCopyable<Line>
{

    public Point Start { get; set; }
    public Point End { get; set; }

    public Line(Point start, Point end)
    {
        Start = start;
        End = end;
    }

    public Line DeepCopy()
    {
        return new Line(Start.DeepCopy(), End.DeepCopy());
    }

    public override string? ToString()
    {
        return $"Start: {Start}, End: {End}";
    }
}

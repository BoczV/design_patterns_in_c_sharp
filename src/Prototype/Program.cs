using Prototype.Entities;

namespace Prototype;

public static class Program
{
    static void Main()
    {
        Point start = new(3, 4);
        Point end = new(5, 6);
        Line line = new Line(start, end);
        Line newLine = line.DeepCopy();

        newLine.Start = new Point(20, 30);
        newLine.End = new Point(40, 50);

        Console.WriteLine(line);

        Console.WriteLine(newLine);

    }
}
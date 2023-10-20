using Adapter.Entities;

namespace Adapter;

public static class Program
{
    static void Main()
    {
        var rectangle = new Rectangle(10, 2);

        var squareToRectangleAdapter = new RectangleToSquareAdapter(rectangle);

        var square = squareToRectangleAdapter.Square;

        int area = square.Area();
        Console.WriteLine(area);
    }
}
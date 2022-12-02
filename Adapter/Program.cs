namespace Adapter;

public static class Program
{
    static void Main()
    {
        Square square = new Square();
        square.Side = 3;

        SquareToRectangleAdapter squareToRectangleAdapter = new SquareToRectangleAdapter(square);

        int area = squareToRectangleAdapter.Area();
        Console.WriteLine(area);
    }
}
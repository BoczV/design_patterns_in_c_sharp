namespace Adapter.Entities;

public class Rectangle : IRectangle
{

    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }
}

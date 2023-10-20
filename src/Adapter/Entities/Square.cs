namespace Adapter.Entities;

public class Square : IRectangle
{
    private int _width;

    public int Width { get { return _width; } set { _width = value; _height = value; } }

    private int _height;

    public int Height { get { return _height; } set { _height = value; _width = value; } }

    public Square(int side)
    {
        Height = side;
    }

}

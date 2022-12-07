using Adapter.Entities;

namespace Adapter;

public class RectangleToSquareAdapter
{
    public Square Square { get; set; }

    public Rectangle Rectangle { get; set; }

    public RectangleToSquareAdapter(Rectangle rectangle)
    {

        Square = new Square((rectangle.Width + rectangle.Height) / 2);
        Rectangle = rectangle;
    }

}

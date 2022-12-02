namespace Adapter;

public class SquareToRectangleAdapter : IRectangle
{
    private Square _square;
    public int Width => _square.Side;

    public int Height => _square.Side;

    public SquareToRectangleAdapter(Square square)
    {
        _square = square;
    }
}

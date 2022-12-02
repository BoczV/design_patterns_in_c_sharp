namespace Adapter;

public interface IRectangle
{
    int Width { get; }
    int Height { get; }
}

public static class ExtensionMethods
{
    public static int Area(this IRectangle rc)
    {
        return rc.Height * rc.Width;
    }
}

namespace Bridge.Renderers;

public class RasterRenderer : IRenderer
{
    public string RenderShape(string shapeName)
    {
        var result = $"I render {shapeName} in a raster way!";
        Console.WriteLine(result);
        return result;
    }
}

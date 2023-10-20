namespace Bridge.Renderers;

public class VectorRenderer : IRenderer
{
    public string RenderShape(string shapeName)
    {
        var result = $"I render {shapeName} in a vector way!";
        Console.WriteLine(result);
        return result;
    }
}

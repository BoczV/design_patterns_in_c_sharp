using Bridge.Renderers;

namespace Bridge.Shapes;

public abstract class Shape
{
    protected string? name;
    private readonly IRenderer _renderer;

    public Shape(IRenderer renderer)
    {
        _renderer = renderer;
    }

    public string Draw()
    {
        return _renderer.RenderShape(name ?? "no name");
    }
}

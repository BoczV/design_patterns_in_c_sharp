using Bridge.Renderers;

namespace Bridge.Shapes;

public class Triangle : Shape
{
    public Triangle(IRenderer renderer) : base(renderer)
    {
        name = "Triangle";
    }
}

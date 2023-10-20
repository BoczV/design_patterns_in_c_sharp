using Bridge.Renderers;
using Bridge.Shapes;

namespace Bridge;

public static class Program
{
    static void Main()
    {
        var shapes = new List<Shape>();
        for (int i = 0; i < 100; i++)
        {
            bool even = i % 2 == 0;
            bool divisibleByThree = i % 3 == 0;

            IRenderer rendererForShape = divisibleByThree ?
                new RasterRenderer()
                : new VectorRenderer();

            Shape shape = even ?
                new Triangle(rendererForShape)
                : new Square(rendererForShape);
            shapes.Add(shape);
        }

        shapes.ForEach(shape => shape.Draw());
    }
}
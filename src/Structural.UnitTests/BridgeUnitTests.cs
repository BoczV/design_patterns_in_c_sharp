using Bridge.Renderers;
using Bridge.Shapes;
using FluentAssertions;
using NUnit.Framework;

namespace Structural.UnitTests;

[TestFixture]
public class BridgeUnitTests
{
    private List<Shape> _shapes;

    [SetUp]
    public void Setup()
    {
        _shapes = new List<Shape>();
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
            _shapes.Add(shape);
        }
    }

    [Test]
    public void TestToRasterRenderASquare()
    {
        // Arrange
        var square = _shapes[3];

        // Act
        string drawing = square.Draw();

        // Assert
        drawing.Should().Be("I render Square in a raster way!");
    }

    [Test]
    public void TestToRasterRenderATriangle()
    {
        // Arrange
        var triangle = _shapes[6];

        // Act
        string drawing = triangle.Draw();

        // Assert
        drawing.Should().Be("I render Triangle in a raster way!");
    }

    [Test]
    public void TestToVectorRenderASquare()
    {
        // Arrange
        var square = _shapes[1];

        // Act
        string drawing = square.Draw();

        // Assert
        drawing.Should().Be("I render Square in a vector way!");
    }

    [Test]
    public void TestToVectorRenderATriangle()
    {
        // Arrange
        var triangle = _shapes[2];

        // Act
        string drawing = triangle.Draw();

        // Assert
        drawing.Should().Be("I render Triangle in a vector way!");
    }
}

using Adapter;
using Adapter.Entities;

namespace Structural.UnitTests;

public class AdapterUnitTests
{
    private RectangleToSquareAdapter? _rectangleToSquareAdapter;

    [Test]
    public void TestCreatedSquare()
    {
        // Arrange
        var rectangle = new Rectangle(5, 7);
        _rectangleToSquareAdapter = new RectangleToSquareAdapter(rectangle);

        // Act
        var square = _rectangleToSquareAdapter.Square;
        int result = square.Area();

        // Assert
        result.Should().Be(36);
    }

    [Test]
    public void TestCreatedSquare2()
    {
        // Arrange
        var rectangle = new Rectangle(3, 10);
        _rectangleToSquareAdapter = new RectangleToSquareAdapter(rectangle);

        // Act
        var square = _rectangleToSquareAdapter.Square;
        int result = square.Area();

        // Assert
        result.Should().Be(36);
    }
}
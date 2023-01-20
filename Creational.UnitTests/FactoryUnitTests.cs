using FluentAssertions;
using NUnit.Framework;
using Singleton.And.Factory.Factory;

namespace Creational.UnitTests;

public class FactoryUnitTests
{
    private ShapeType _shapeType;


    [Test]
    public void TestTriangle()
    {
        // Arrange
        _shapeType = ShapeType.Triangle;

        // Act
        var entity = ShapeFactory.GetShape(_shapeType);

        // Assert
        entity.Name.Should().Be("Triangle");
    }

    [Test]
    public void TestSquare()
    {
        // Arrange
        _shapeType = ShapeType.Square;

        // Act
        var entity = ShapeFactory.GetShape(_shapeType);

        // Assert
        entity.Name.Should().Be("Square");
    }

    [Test]
    public void TestCircle()
    {
        // Arrange
        _shapeType = ShapeType.Circle;

        // Act
        var entity = ShapeFactory.GetShape(_shapeType);

        // Assert
        entity.Name.Should().Be("Circle");
    }
}

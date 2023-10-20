using Singleton;
using Singleton.And.Factory.Factory;

namespace Creational.UnitTests;

[TestFixture]
public class SingletonUnitTests
{
    private ShapeType _shapeType;


    [Test]
    public void TestIfShapeIsNotSingleton()
    {
        // Arrange
        _shapeType = ShapeType.Triangle;
        var func = ShapeFactory.GetShape;

        // Act
        var result = SingletonTester.IsSingleton(func, _shapeType);

        // Assert
        result.Should().Be(false);

    }

    [Test]
    public void TestIfShapeIsSingleton()
    {
        // Arrange
        _shapeType = ShapeType.Circle;
        var func = ShapeFactory.GetShape;

        // Act
        var result = SingletonTester.IsSingleton(func, _shapeType);

        // Assert
        result.Should().Be(true);

    }
}

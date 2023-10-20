using Prototype.Entities;

namespace Creational.UnitTests;

[TestFixture]
public class PrototypeUnitTests
{
    private Line _line;
    private Line? _anotherLine;

    [SetUp]
    public void Setup()
    {
        var start = new Point(10, 10);
        var end = new Point(10, 10);
        _line = new Line(start, end);
    }


    [Test]
    public void TestIfCopiedIsNotTheSame()
    {
        // Arrange

        // Act
        _anotherLine = _line.DeepCopy();

        // Assert
        _anotherLine.GetHashCode().Should().NotBe(_line.GetHashCode());

    }

    [Test]
    public void TestIfReferencedIsTheSame()
    {
        // Arrange

        // Act
        _anotherLine = _line;

        // Assert
        _anotherLine.GetHashCode().Should().Be(_line.GetHashCode());

    }

}

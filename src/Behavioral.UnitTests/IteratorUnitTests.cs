using Iterator;
namespace Behavioral.UnitTests;

[TestFixture]
public class IteratorUnitTests
{
    private MyLinkedList<string> _iterator;

    [SetUp]
    public void Setup()
    {
        _iterator = new MyLinkedList<string>();
    }

    [Test]
    public void TestAddition()
    {
        // Arrange
        var firstString = "apa";
        var secondString = "cuka";

        var stringResult = "[apa, cuka]";

        // Act
        _iterator.Add(firstString);
        _iterator.Add(secondString);

        // Assert
        var result = _iterator.ToString();
        result.Should().Be(stringResult);
    }

    [Test]
    public void TestGetElement()
    {
        // Arrange
        var firstString = "apa";
        var secondString = "cuka";
        var thirdString = "funda";

        _iterator.Add(firstString);
        _iterator.Add(secondString);
        _iterator.Add(thirdString);

        // Act
        var secondElement = _iterator.Get(1);

        // Assert
        secondElement.Should().Be(secondElement);
    }

    [Test]
    public void TestGetIndexOf()
    {
        // Arrange
        var firstString = "apa";
        var secondString = "cuka";
        var thirdString = "funda";

        _iterator.Add(firstString);
        _iterator.Add(secondString);
        _iterator.Add(thirdString);

        // Act
        var secondElement = _iterator.GetIndexOf(thirdString);

        // Assert
        secondElement.Should().Be(2);
    }

    [Test]
    public void TestGetIndexOf2()
    {
        // Arrange & Act
        var index = _iterator.GetIndexOf("cuka");

        // Assert
        index.Should().Be(-1);
    }

    [Test]
    public void TestLastAndFirstElement()
    {
        // Arrange
        var firstString = "apa";
        var secondString = "cuka";
        var thirdString = "funda";

        _iterator.Add(firstString);
        _iterator.Add(secondString);
        _iterator.Add(thirdString);

        // Act
        var last = _iterator.Last();
        var first = _iterator.First();

        // Assert
        last.Should().Be(thirdString);
        first.Should().Be(firstString);
    }

    [Test]
    public void TestLength()
    {
        // Arrange
        var firstString = "apa";
        var secondString = "cuka";
        var thirdString = "funda";

        _iterator.Add(firstString);
        _iterator.Add(secondString);
        _iterator.Add(thirdString);

        // Act
        var length = _iterator.Length();

        // Assert
        length.Should().Be(3);
    }

    [Test]
    public void TestContains()
    {
        // Arrange
        var firstString = "apa";
        var secondString = "cuka";
        var thirdString = "funda";

        _iterator.Add(firstString);
        _iterator.Add(secondString);
        _iterator.Add(thirdString);

        // Act
        var contains = _iterator.Contains("cuka");

        // Assert
        contains.Should().BeTrue();
    }

    [Test]
    public void TestFirst()
    {
        // Arrange & Act
        var call = () => _iterator.First();

        // Assert
        call.Should().Throw<NullReferenceException>();
    }
}

using Flyweight;


namespace Structural.UnitTests;

[TestFixture]
public class FlyweightUnitTests
{

    [Test]
    public void TestCapitalizationOfFirstWord()
    {
        // Arrange
        var sentence = new Sentence("we are testing Flyweight!");

        // Act
        sentence[0].Capitalize = true;

        // Assert
        var stringSentence = sentence.ToString();
        stringSentence.Should().Be("WE are testing Flyweight!");

    }

    [Test]
    public void TestCapitalizationOfMultipleWord()
    {
        // Arrange
        var sentence = new Sentence("we are testing Flyweight!");

        // Act
        sentence[0].Capitalize = true;
        sentence[2].Capitalize = true;

        // Assert
        var stringSentence = sentence.ToString();
        stringSentence.Should().Be("WE are TESTING Flyweight!");

    }
}

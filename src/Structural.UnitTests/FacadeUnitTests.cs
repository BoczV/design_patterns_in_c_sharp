using Facade.MagicSquare;

namespace Structural.UnitTests;

[TestFixture]
public class FacadeUnitTests
{
    private List<List<int>> _magicSquare;

    [SetUp]
    public void Setup()
    {
        _magicSquare = MagicSquareGenerator.Generate(4);
    }

    [Test]
    public void TestIfRowsAddUpToTheSameValue()
    {
        // Arrange
        var firstRowSum = 0;
        var secondRowSum = 0;
        var thirdRowSum = 0;
        var fourthRowSum = 0;

        // Act
        _magicSquare[0].ForEach(x => firstRowSum += x);
        _magicSquare[1].ForEach(x => secondRowSum += x);
        _magicSquare[2].ForEach(x => thirdRowSum += x);
        _magicSquare[3].ForEach(x => fourthRowSum += x);

        // Assert
        firstRowSum.Should().Be(secondRowSum);
        firstRowSum.Should().Be(thirdRowSum);
        firstRowSum.Should().Be(fourthRowSum);
    }

    [Test]
    public void TestIfColumnsAddUpToTheSameValue()
    {
        // Arrange
        int firstColumnSum = 0;
        int secondColumnSum = 0;
        int thirdColumnSum = 0;
        int fourthColumnSum = 0;

        // Act
        _magicSquare.ForEach(x => firstColumnSum += x[0]);
        _magicSquare.ForEach(x => secondColumnSum += x[1]);
        _magicSquare.ForEach(x => thirdColumnSum += x[2]);
        _magicSquare.ForEach(x => fourthColumnSum += x[3]);

        // Assert
        firstColumnSum.Should().Be(secondColumnSum);
        firstColumnSum.Should().Be(thirdColumnSum);
        firstColumnSum.Should().Be(fourthColumnSum);
    }

    [Test]
    public void TestIfDiagonalsAddUpToTheSameValue()
    {
        // Arrange
        var firstDiagonalSum = 0;
        var secondDiagonalSum = 0;

        // Act
        for (var i = 0; i < _magicSquare.Count; i++)
        {
            firstDiagonalSum += _magicSquare[i][i];
            secondDiagonalSum += _magicSquare[i][_magicSquare.Count - 1 - i];
        }

        // Assert
        firstDiagonalSum.Should().Be(secondDiagonalSum);
    }
}

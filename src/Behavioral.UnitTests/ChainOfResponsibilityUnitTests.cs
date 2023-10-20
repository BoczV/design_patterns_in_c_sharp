using Chain.Of.Responsibility.Calculator;

namespace Behavioral.UnitTests;

[TestFixture]
public class ChainOfResponsibilityUnitTests
{
    private ChainCalculator _chainCalculator;

    [SetUp]
    public void Setup()
    {
        _chainCalculator = new ChainCalculator();
    }

    [Test]
    public void TestAddition()
    {
        // Arrange
        OperationType operationType = OperationType.Addition;
        double firstNumber = 10;
        double secondNumber = 5;

        //Act
        double result = _chainCalculator.HandleRequest(operationType, firstNumber, secondNumber);

        //Assert
        result.Should().Be(15);
    }

    [Test]
    public void TestSubtraction()
    {
        // Arrange
        OperationType operationType = OperationType.Subtraction;
        double firstNumber = 10;
        double secondNumber = 5;

        //Act
        double result = _chainCalculator.HandleRequest(operationType, firstNumber, secondNumber);

        //Assert
        result.Should().Be(5);
    }

    [Test]
    public void TestMultiplication()
    {
        // Arrange
        OperationType operationType = OperationType.Multiplication;
        double firstNumber = 5;
        double secondNumber = 10;

        //Act
        double result = _chainCalculator.HandleRequest(operationType, firstNumber, secondNumber);

        //Assert
        result.Should().Be(50);
    }

    [Test]
    public void TestDivision()
    {
        // Arrange
        OperationType operationType = OperationType.Division;
        double firstNumber = 10;
        double secondNumber = 5;

        //Act
        double result = _chainCalculator.HandleRequest(operationType, firstNumber, secondNumber);

        //Assert
        result.Should().Be(2);
    }
}
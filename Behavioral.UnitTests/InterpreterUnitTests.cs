using FluentAssertions;
using Interpreter;
using NUnit.Framework;

namespace Behavioral.UnitTests;

[TestFixture]
public class InterpreterUnitTests
{
    private ExpressionProcessor _expressionProcessor;

    [SetUp]
    public void Setup()
    {
        _expressionProcessor = new ExpressionProcessor();
    }

    [Test]
    public void TestOperationWithVariable()
    {
        // Arrange
        var variableKey = "x";
        var variableValue = 100;
        var strExpression = "2*x";

        // Act
        _expressionProcessor.AddNewVariable(variableKey, variableValue);
        _expressionProcessor.GetOneExpression(strExpression);
        var result = _expressionProcessor.Calculate();

        // Assert
        result.Should().Be(200);
    }

    [Test]
    public void TestAddition()
    {
        // Arrange
        var strExpression = "2+10";

        // Act
        _expressionProcessor.GetOneExpression(strExpression);
        var result = _expressionProcessor.Calculate();

        // Assert
        result.Should().Be(12);
    }

    [Test]
    public void TestSubtraction()
    {
        // Arrange
        var strExpression = "200-10";

        // Act
        _expressionProcessor.GetOneExpression(strExpression);
        var result = _expressionProcessor.Calculate();

        // Assert
        result.Should().Be(190);
    }

    [Test]
    public void TestMultiplication()
    {
        // Arrange
        var strExpression = "200*2";

        // Act
        _expressionProcessor.GetOneExpression(strExpression);
        var result = _expressionProcessor.Calculate();

        // Assert
        result.Should().Be(400);
    }

    [Test]
    public void TestDivision()
    {
        // Arrange
        var strExpression = "1900/2";

        // Act
        _expressionProcessor.GetOneExpression(strExpression);
        var result = _expressionProcessor.Calculate();

        // Assert
        result.Should().Be(950);
    }
}

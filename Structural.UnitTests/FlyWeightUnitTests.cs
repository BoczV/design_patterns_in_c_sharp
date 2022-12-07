using FluentAssertions;
using Flyweight;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Structural.UnitTests;

[TestFixture]
public class FlyWeightUnitTests
{
    [SetUp]
    public void Setup()
    {
    }

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

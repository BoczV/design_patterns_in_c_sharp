using FluentAssertions;
using NUnit.Framework;
using State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.UnitTests;

[TestFixture]
public class StateUnitTests
{
    private CombinationLock _combinationLock;
    int[] _combination;

    [SetUp]
    public void Setup()
    {
        _combination = new[] { 1, 2, 3, 4, 5 };
        _combinationLock = new CombinationLock(_combination);
    }

    [Test]
    public void TestUnLock()
    {
        // Arrange

        // Act
        for (int i = 0; i < _combination.Length; i++)
        {
            _combinationLock.EnterDigit(_combination[i]);
        }

        //Assert
        _combinationLock.Status.Should().Be("OPEN");

    }

    [Test]
    public void TestError()
    {
        // Arrange

        // Act
        for (int i = 0; i < _combination.Length; i++)
        {
            _combinationLock.EnterDigit(2);
        }

        //Assert
        _combinationLock.Status.Should().Be("ERROR");

    }

    [Test]
    public void TestLock()
    {
        // Arrange

        // Act

        //Assert
        _combinationLock.Status.Should().Be("LOCKED");

    }
}

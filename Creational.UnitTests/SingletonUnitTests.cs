using FluentAssertions;
using NUnit.Framework;
using Prototype.Entities;
using Singleton;
using Singleton.And.Factory.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

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

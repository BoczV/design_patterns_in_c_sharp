using Null_Object;

namespace Creational.UnitTests;

[TestFixture]
public class NullObjectUnitTests
{
    private Account _account;

    [SetUp]
    public void Setup()
    {
        ILog log = new ConsoleLog();
        _account = new Account(log);
    }

    [Test]
    public void TestIfAccountWorksFineWithLogger()
    {
        // Arrange

        // Act
        var result = () => _account.Deposite(100);

        // Assert
        result.Should().NotThrow();

    }

    [Test]
    public void TestIfAccountWorksFineWithNullLogger()
    {
        // Arrange
        _account.Log = null!;

        // Act
        var result = () => _account.Withdraw(100);

        // Assert
        result.Should().NotThrow();

    }
}
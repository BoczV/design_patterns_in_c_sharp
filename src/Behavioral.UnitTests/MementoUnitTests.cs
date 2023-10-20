using FluentAssertions;
using Memento;
using NUnit.Framework;

namespace Behavioral.UnitTests;

[TestFixture]
public class MementoUnitTests
{
    private BankAccount _bankAccount;

    private string _defaultOwnerName;

    private string _defaultAccountType;

    [SetUp]
    public void Setup()
    {
        _defaultOwnerName = "Erika";
        _defaultAccountType = "Retail";
        _bankAccount = new BankAccount(_defaultOwnerName, _defaultAccountType);
    }

    [Test]
    public void TestMementoRestore()
    {
        // Arrange
        Guid guid = _bankAccount.Deposit(100);
        _bankAccount.Deposit(100);
        _bankAccount.OwnerName = "Károly";
        _bankAccount.AccountType = "SomethingElse";

        // Act
        _bankAccount.Reset(guid);

        // Assert
        _bankAccount.OwnerName.Should().Be(_defaultOwnerName);
        _bankAccount.AccountType.Should().Be(_defaultAccountType);

    }
}

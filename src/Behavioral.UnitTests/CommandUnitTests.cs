using Command;
using Command.Commands;

namespace Behavioral.UnitTests;

[TestFixture]
public class CommandUnitTests
{
    private BankAccount _bankAccount;

    [SetUp]
    public void Setup()
    {
        _bankAccount = new BankAccount();
    }

    [Test]
    public void TestOneOperation()
    {
        // Arrange
        var bankAccountCommand = new BankAccountCommand(_bankAccount, BankAccountCommand.ActionType.Deposit, 10000);

        // Act
        bankAccountCommand.Process();

        // Assert
        _bankAccount.Balance.Should().Be(10000);
    }

    [Test]
    public void TestManyOperations()
    {
        // Arrange
        var commandList = new List<BankAccountCommand>
        {
            new BankAccountCommand(_bankAccount, BankAccountCommand.ActionType.Withdraw, 10000),
            new BankAccountCommand(_bankAccount, BankAccountCommand.ActionType.Deposit, 10000),
            new BankAccountCommand(_bankAccount, BankAccountCommand.ActionType.Deposit, 10000),
            new BankAccountCommand(_bankAccount, BankAccountCommand.ActionType.Withdraw, 12010),
            new BankAccountCommand(_bankAccount, BankAccountCommand.ActionType.Deposit, 10000),

        };

        // Act
        commandList.ForEach(command => command.Process());

        // Assert
        _bankAccount.Balance.Should().Be(17990);
    }
}

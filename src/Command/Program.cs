using Command.Commands;

namespace Command;

public static class Program
{
    static void Main()
    {
        var ba = new BankAccount();
        var commandList = new List<BankAccountCommand>
        {
            new BankAccountCommand(ba, BankAccountCommand.ActionType.Withdraw, 10000),
            new BankAccountCommand(ba, BankAccountCommand.ActionType.Deposit, 10000),
            new BankAccountCommand(ba, BankAccountCommand.ActionType.Deposit, 10000),
            new BankAccountCommand(ba, BankAccountCommand.ActionType.Withdraw, 12010),
            new BankAccountCommand(ba, BankAccountCommand.ActionType.Deposit, 10000),

        };

        Console.WriteLine(ba);

        Console.WriteLine("\nCommands:");
        commandList.ForEach(command =>
        {
            command.Process();
            Console.WriteLine($"*  ActionType: {command.Action}, Successful: {command.Success}, Amount: {command.Amount}");
        }

        );

        Console.WriteLine();
        Console.WriteLine(ba);
    }
}
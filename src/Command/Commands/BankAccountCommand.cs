namespace Command.Commands;

public class BankAccountCommand : ICommand
{
    public enum ActionType
    {
        Deposit,
        Withdraw
    }

    public BankAccount BankAccount { get; set; }
    public ActionType Action { get; set; }
    public int Amount { get; set; }

    private bool _success;

    public bool Success { get { return _success; } }

    public BankAccountCommand(BankAccount bankAccount, ActionType action, int amount)
    {
        BankAccount = bankAccount;
        Action = action;
        Amount = amount;
    }

    public void Process()
    {
        switch (Action)
        {
            case ActionType.Deposit:
                _success = BankAccount.Deposit(Amount);
                break;
            case ActionType.Withdraw:
                _success = BankAccount.Withdraw(Amount);
                break;
            default:
                throw new ArgumentException($"Unknown action type: {Action}");
        }
    }
}

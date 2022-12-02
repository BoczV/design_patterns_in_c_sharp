namespace Command;
public class BankAccount
{

    private int _balance;

    public int Balance { get { return _balance; } }

    public bool Deposit(int amount)
    {
        _balance += amount;
        return true;
    }

    public bool Withdraw(int amount)
    {
        if (_balance - amount >= 0)
        {
            _balance -= amount;
            return true;
        }
        return false;
    }

    public override string? ToString()
    {
        return $"Balance: {_balance}";
    }
}

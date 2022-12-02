namespace Memento;

public class BankAccount
{
    private string _ownerName;
    public string OwnerName
    {
        get => _ownerName;
        set
        {
            _ownerName = value;
            SaveNewRecord();
        }
    }

    private int _balance;

    private string _accountType;
    public string AccountType
    {
        get => _accountType;
        set
        {
            _accountType = value;
            SaveNewRecord();
        }
    }

    private readonly Dictionary<Guid, Memento> history = new();

    private sealed class Memento
    {
        public string OwnerName { get; set; }
        public int Balance { get; set; }

        public string AccountType { get; set; }

        public Memento(string ownerName, int balance, string accountType)
        {
            OwnerName = ownerName;
            this.Balance = balance;
            AccountType = accountType;
        }
    }

    public BankAccount(string ownerName, string accountType)
    {
        _balance = 0;
        _ownerName = ownerName;
        _accountType = accountType;
    }

    public BankAccount(string ownerName, int balance, string accountType)
    {
        _ownerName = ownerName;
        _balance = balance;
        _accountType = accountType;
    }

    public Guid Deposit(int amount)
    {
        _balance += amount;
        return SaveNewRecord();
    }

    public Guid Withdraw(int amount)
    {
        _balance -= amount;
        return SaveNewRecord();
    }

    private Guid SaveNewRecord()
    {
        var newGuid = Guid.NewGuid();
        var memento = new Memento(OwnerName, _balance, AccountType);
        history.Add(newGuid, memento);
        return newGuid;
    }

    public void Reset(Guid guid)
    {
        if (history.ContainsKey(guid))
        {
            Memento? memento = history.GetValueOrDefault(guid);
            if (memento != null)
            {
                _balance = memento.Balance;
                _accountType = memento.AccountType;
                _ownerName = memento.OwnerName;
            }
        }
    }

    public override string? ToString()
    {
        return $"Owner name: {OwnerName}, account type: {AccountType}, balance: {_balance}";
    }
}

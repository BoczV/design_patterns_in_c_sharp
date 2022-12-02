namespace Null_Object;

public class Account
{
    private ILog _log;
    public ILog Log
    {
        get { return _log; }
        set { _log = value ?? ILog.Null; }
    }

    private int balance;

    public Account(ILog log)
    {
        _log = log ?? ILog.Null;
    }

    public void Deposite(int number)
    {
        balance += number;
        var result = $"Deposit: {number}, balance now: {balance}";
        if (balance <= 0)
        {
            WarnUserAboutBalance();
        }
        else
        {
            Log.LogInfo(result);
        }
    }

    private void WarnUserAboutBalance()
    {
        var warning = $"Your balance actual balance is smaller than or equals to 0. Balance: {balance}";
        Log.LogWarning(warning);
    }
}

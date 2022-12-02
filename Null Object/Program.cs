using Null_Object;

namespace Null.Object;

public static class Program
{
    static void Main()
    {
        var iLog = new ConsoleLog();
        ILog nullLog = null!;
        var account = new Account(iLog);
        for (int i = 0; i < 10; i++)
        {
            account.Deposite(100);
            if (i == 3)
            {
                account.Log = nullLog;
            }

            if (i == 6)
            {
                account.Log = iLog;
            }
        }
    }
}
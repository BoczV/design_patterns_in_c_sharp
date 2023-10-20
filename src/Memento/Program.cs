namespace Memento;

public static class Program
{
    static void Main()
    {
        var ba = new BankAccount("Erika", "Retail");
        Guid guid1 = ba.Deposit(100);
        Guid guid2 = ba.Withdraw(32);
        ba.OwnerName = "Károly";
        ba.AccountType = "SomethingElse";
        Console.WriteLine(ba);
        ba.Reset(guid1);
        Console.WriteLine(ba);
    }
}
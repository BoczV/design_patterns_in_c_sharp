namespace Memento;

public static class Program
{
    static void Main()
    {
        var ba = new BankAccount("Erika", "Retail");
        var guid = ba.Deposit(100);
        ba.OwnerName = "Károly";
        ba.AccountType = "SomethingElse";
        Console.WriteLine(ba);
        ba.Reset(guid);
        Console.WriteLine(ba);
    }
}

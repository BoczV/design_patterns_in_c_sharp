namespace Null_Object;

public class ConsoleLog : ILog
{
    public void LogError(string message)
    {
        Console.WriteLine($"ERROR!! {message}");
    }

    public void LogInfo(string message)
    {
        Console.WriteLine(message);
    }

    public void LogWarning(string message)
    {
        Console.WriteLine($"WARNING!! {message}");
    }
}

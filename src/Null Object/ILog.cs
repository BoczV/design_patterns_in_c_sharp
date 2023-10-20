namespace Null_Object;

public interface ILog
{
    void LogInfo(string message);

    void LogWarning(string message);

    void LogError(string message);

    public static ILog Null => NullLog.GetInstance();

    private sealed class NullLog : ILog
    {
        private NullLog() { }

        private static readonly Lazy<NullLog> _instance = new(() => new NullLog());

        public static NullLog GetInstance()
        {
            return _instance.Value;
        }

        public void LogError(string message)
        {
            System.Console.WriteLine("Logger is null");
        }

        public void LogInfo(string message)
        {
            System.Console.WriteLine("Logger is null");
        }

        public void LogWarning(string message)
        {
            System.Console.WriteLine("Logger is null");
        }
    }
}

namespace State;

public static class Program
{
    static void Main()
    {
        int[] combination = new[] { 1, 2, 3, 4, 5 };
        var combinationLock = new CombinationLock(combination);
        OpenCombinationLock(combination, combinationLock);
    }

    public static void OpenCombinationLock(int[] combination, CombinationLock combinationLock)
    {
        Console.WriteLine($"Actual status of combination lock: {combinationLock.Status}");

        for (int i = 0; i < combination.Length; i++)
        {
            combinationLock.EnterDigit(combination[i]);
            Console.WriteLine($"Status: {combinationLock.Status}");
        }
    }
}
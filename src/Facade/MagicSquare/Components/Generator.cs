using System.Security.Cryptography;

namespace Facade.MagicSquare.Components;

public static class Generator
{
    public static List<int> Generate(int count, int limit)
    {
        return Enumerable.Range(0, count)
            .Select(_ => GenerateRandomNumber(1, limit))
            .ToList();
    }

    private static int GenerateRandomNumber(int minValue, int maxValue)
    {
        using var randomGenerator = RandomNumberGenerator.Create();
        var data = new byte[4];
        randomGenerator.GetBytes(data);

        // Convert the 4 bytes to an integer
        var randomNumber = BitConverter.ToInt32(data, 0);

        // Make sure the generated number is non-negative and within the specified range
        var range = maxValue - minValue + 1;
        var randomNonNegativeNumber = Math.Abs(randomNumber % range);

        return randomNonNegativeNumber + minValue;
    }
}

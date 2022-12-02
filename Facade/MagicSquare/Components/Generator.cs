namespace Facade.MagicSquare.Components;

public static class Generator
{
    private static readonly Random random = new Random();

    public static List<int> Generate(int count, int limit)
    {
        return Enumerable.Range(0, count)
            .Select(_ => random.Next(1, limit))
            .ToList();
    }
}

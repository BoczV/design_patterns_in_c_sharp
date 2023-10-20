namespace Facade.MagicSquare.Components;

public static class Verifier
{
    public static bool Verify(List<List<int>> array)
    {
        if (!array.Any())
        {
            return false;
        }

        var expectedValue = array.FirstOrDefault()?.Sum() ?? 0;

        return array.TrueForAll(subList => subList.Sum() == expectedValue);
    }
}

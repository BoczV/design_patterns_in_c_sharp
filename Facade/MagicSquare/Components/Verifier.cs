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

        return array.All(subList => subList.Sum() == expectedValue);
    }
}

namespace Facade;

using MagicSquare;

public static class Program
{
    static void Main()
    {
        List<List<int>> magicSquare = MagicSquareGenerator.Generate(4);
        magicSquare.ForEach(
            x => x.ForEach(
                y => Console.WriteLine($"{magicSquare.IndexOf(x) + 1}. sublist, {x.IndexOf(y) + 1}. element is {y}.")
                )
            );
    }
}
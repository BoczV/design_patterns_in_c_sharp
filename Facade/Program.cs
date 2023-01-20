namespace Facade;

using MagicSquare;
using System.Text;

public static class Program
{
    static void Main()
    {
        List<List<int>> magicSquare = MagicSquareGenerator.Generate(5);
        for (int i = 0; i < magicSquare.Count; i++)
        {
            Console.WriteLine("----------");
            var subList = magicSquare[i];
            var strBuilder = new StringBuilder('|');
            for (int j = 0; j < subList.Count; j++)
            {
                strBuilder.Append(subList[j]).Append('|');
            }
            Console.WriteLine(strBuilder);
        }
        Console.WriteLine("----------");
    }
}
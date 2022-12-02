using Facade.MagicSquare.Components;

namespace Facade.MagicSquare;

public static class MagicSquareGenerator
{
    public static List<List<int>> Generate(int size)
    {
        bool IsItAMagicSquare;
        List<List<int>> list;
        do
        {
            list = new();
            for (int i = 0; i < size; i++)
            {
                list.Add(Generator.Generate(size, size));
            }
            List<List<int>> splittedList = Splitter.Split(list);

            IsItAMagicSquare = Verifier.Verify(splittedList);

        } while (!IsItAMagicSquare);

        return list;
    }



}
namespace Facade.MagicSquare.Components;
public static class Splitter
{
    public static List<List<int>> Split(List<List<int>> array)
    {
        var result = new List<List<int>>();

        var rowCount = array.Count;
        var colCount = array[0].Count;

        // get the rows
        for (int r = 0; r < rowCount; ++r)
        {
            var theRow = new List<int>();
            for (int c = 0; c < colCount; ++c)
                theRow.Add(array[r][c]);
            result.Add(theRow);
        }

        // get the columns
        for (int c = 0; c < colCount; ++c)
        {
            var theCol = new List<int>();
            for (int r = 0; r < rowCount; ++r)
                theCol.Add(array[r][c]);
            result.Add(theCol);
        }

        // now the diagonals
        var diag1 = new List<int>();
        var diag2 = new List<int>();
        for (int c = 0; c < colCount; ++c)
        {
            for (int r = 0; r < rowCount; ++r)
            {
                if (c == r)
                    diag1.Add(array[r][c]);
                var r2 = rowCount - r - 1;
                if (c == r2)
                    diag2.Add(array[r][c]);
            }
        }

        result.Add(diag1);
        result.Add(diag2);

        return result;
    }
}

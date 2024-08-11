namespace LeetCode.Easy;

public class ExcelSheetCellRangeSolution
{
    public static IList<string> CellsInRange(string s)
    {
        char[] alphabet = Enumerable.Range('A', 26).Select(n => (char)n).ToArray();
        List<string> cells = new List<string>();

        int colFirstIndex = Array.IndexOf(alphabet, s[0]);
        int colLastIndex = Array.IndexOf(alphabet, s[3]);
        int rowFirstIndex = int.Parse(s[1].ToString());
        int rowLastIndex = int.Parse(s[^1].ToString());

        for (int i = colFirstIndex; i <= colLastIndex; i++)
        {
            for (int j = rowFirstIndex; j <= rowLastIndex; j++)
            {
                cells.Add($"{alphabet[i]}{j}");
            }
        }

        return cells;
    }
}
namespace LeetCode.Easy;

public class ExcelSheetCellRangeSolution
{
    public static IList<string> CellsInRange(string s)
    {
        char[] alphabet = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'];
        Queue<string> cells = new Queue<string>();

        int colFirstIndex = Array.IndexOf(alphabet, s[0]);
        int colLastIndex = Array.IndexOf(alphabet, s[^2]);
        int rowFirstIndex = int.Parse(s[1].ToString());
        int rowLastIndex = int.Parse(s[^1].ToString());

        for (int i = colFirstIndex; i <= colLastIndex; i++)
        {
            for (int j = rowFirstIndex; j <= rowLastIndex; j++)
            {
                cells.Enqueue($"{alphabet[i]}{j}");
            }
        }

        return cells.ToArray();
    }
}
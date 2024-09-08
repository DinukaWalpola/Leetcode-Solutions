namespace LeetCode.Easy;

public class DeleteColumnsToMakeSortedSolution
{
    public static int MinDeletionSize(string[] strs)
    {
        int shouldDeleteCount = 0;
        char[] col = new char[strs.Length];

        for (int i = 0; i < strs[0].Length; i++)
        {
            for (int j = 0; j < strs.Length; j++)
            {
                col[j] = strs[j][i];
            }

            for (int j = 0; j < col.Length - 1; j++)
            {
                if (col[j] > col[j + 1])
                {
                    shouldDeleteCount++;
                    break;
                }
            }

            if (strs[0].Length == 1) return shouldDeleteCount;
        }

        return shouldDeleteCount;
    }
}
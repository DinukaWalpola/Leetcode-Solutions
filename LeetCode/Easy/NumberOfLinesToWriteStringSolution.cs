namespace LeetCode.Easy;

public class NumberOfLinesToWriteStringSolution
{
    public static int[] NumberOfLines(int[] widths, string s)
    {
        int lineCount = 0;
        int totalPixelsInOneLine = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int index = widths[s[i] - 97];
            if (totalPixelsInOneLine + index <= 100)
            {
                totalPixelsInOneLine += index;
            }
            else
            {
                lineCount++;
                totalPixelsInOneLine = index;
            }
        }

        return [++lineCount, totalPixelsInOneLine];
    }
}
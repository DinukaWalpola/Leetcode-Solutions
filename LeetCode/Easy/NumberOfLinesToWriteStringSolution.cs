namespace LeetCode.Easy;

public class NumberOfLinesToWriteStringSolution
{
    public static int[] NumberOfLines(int[] widths, string s)
    {
        int lineCount = 0;
        int totalPixelsInOneLine = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (totalPixelsInOneLine + widths[s[i] - 97] <= 100)
            {
                totalPixelsInOneLine += widths[s[i] - 97];
            }
            else
            {
                lineCount++;
                totalPixelsInOneLine = widths[s[i] - 97];
            }
        }

        lineCount++;

        return [lineCount, totalPixelsInOneLine];
    }
}
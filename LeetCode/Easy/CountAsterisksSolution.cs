namespace LeetCode.Easy;

public class CountAsterisksSolution
{
    public static int CountAsterisks(string s)
    {
        int barsCount = 0;
        int asterisksCount = 0;

        foreach (var c in s)
        {
            if (barsCount == 0)
            {
                if (c == '*')
                {
                    asterisksCount++;
                }
            }

            if (c == '|')
            {
                if (barsCount == 1)
                {
                    barsCount = -1;
                }

                barsCount++;
            }
        }

        return asterisksCount;
    }
}
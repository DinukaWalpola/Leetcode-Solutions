namespace LeetCode.Easy;

public class JewelsAndStones
{
    public static int NumJewelsInStones(string jewels, string stones)
    {
        int count = 0;

        foreach (var s in stones)
        {
            if (jewels.Contains(s))
            {
                count++;
            }
        }

        return count;
    }
}
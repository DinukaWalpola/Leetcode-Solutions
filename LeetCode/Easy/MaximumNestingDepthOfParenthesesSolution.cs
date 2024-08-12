namespace LeetCode.Easy;

public class MaximumNestingDepthOfParenthesesSolution
{
    public static int MaxDepth(string s)
    {
        int count = 0;
        int maxCount = 0;

        foreach (var c in s)
        {
            if (c == '(')
            {
                count++;
            }
            else if (c == ')')
            {
                count--;
            }

            if (count > maxCount)
            {
                maxCount = count;
            }
        }

        return maxCount;
    }
}
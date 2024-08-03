namespace LeetCode.Easy;

public class SplitStringInABalanceStringSolution
{
    public static int BalancedStringSplit(string s)
    {
        int count = 0;
        int pairCount = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'R')
            {
                count++;
            } 
            else if (s[i] == 'L')
            {
                count--;
            }

            if (count == 0)
            {
                pairCount++;
            }
        }
        
        return pairCount;
    }
}
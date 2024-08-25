namespace LeetCode.Easy;

public class LexicographicallySmallestPalindromeSolution
{
    public static string MakeSmallestPalindrome(string s)
    {
        char[] leftSide = s.Substring(0, s.Length / 2).ToCharArray();
        char[] rightSide = s.Length % 2 == 0
            ? s.Substring(s.Length / 2).ToCharArray()
            : s.Substring((s.Length / 2) + 1).ToCharArray();

        for (int i = 0; i < leftSide.Length; i++)
        {
            if ((int)leftSide[i] > (int)rightSide[rightSide.Length - 1 - i])
            {
                leftSide[i] = rightSide[rightSide.Length - 1 - i];
            }
            else if ((int)leftSide[i] < (int)rightSide[rightSide.Length - 1 - i])
            {
                rightSide[rightSide.Length - 1 - i] = leftSide[i];
            }
        }

        return s.Length % 2 == 0
            ? new string(leftSide) + new string(rightSide)
            : new string(leftSide) + s[s.Length / 2] + new string(rightSide);
    }
}
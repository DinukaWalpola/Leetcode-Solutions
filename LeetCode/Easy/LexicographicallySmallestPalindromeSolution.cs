namespace LeetCode.Easy;

public class LexicographicallySmallestPalindromeSolution
{
    public static string MakeSmallestPalindrome(string s)
    {
        char[] inputStr = s.ToCharArray();
        
        for (int i = 0; i < s.Length / 2; i++)
        {
            if ((int)s[i] > (int)s[s.Length - 1 - i])
            {
                inputStr[i] = s[s.Length - 1 - i];
            }
            else if ((int)s[i] < (int)s[s.Length - 1 - i])
            {
                inputStr[s.Length - 1 - i] = s[i];
            }
        }

        return new string(inputStr);
    }
}
namespace LeetCode.Easy;

public class FirstPalindromeStringSolution
{
    public static string FirstPalindrome(string[] words)
    {
        bool isPalindrome = true;

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length == 1)
            {
                return words[i];
            }
            
            for (int j = 0; j < words[i].Length / 2; j++)
            {
                if (words[i][j] != words[i][words[i].Length - j - 1])
                {
                    isPalindrome = false;
                    break;
                }
            }
            
            if (isPalindrome)
            {
                return words[i];
            }
            
            isPalindrome = true;
        }

        return String.Empty;
    }
}
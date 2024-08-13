namespace LeetCode.Easy;

public class FirstPalindromeStringSolution
{
    public static string FirstPalindrome(string[] words)
    {
        string palindromeString = "";
        bool isPalindrome = true;
        int currentWordIndex = 0;

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length == 1)
            {
                return words[i];
            }
            
            for (int j = 0; j < words[i].Length; j++)
            {
                if (j != words[i].Length / 2)
                {
                    if (words[i][j] != words[i][words[i].Length - j - 1])
                    {
                        isPalindrome = false;
                        break;
                    }
                    else
                    {
                        currentWordIndex = i;
                        isPalindrome = true;
                    }
                }
            }

            if (isPalindrome)
            {
                palindromeString = words[currentWordIndex];
                break;
            }
        }

        return palindromeString;
    }
}
namespace LeetCode.Easy;

public class ValidPalindromeSolution
{
    public static bool IsPalindrome(string s)
    {
        s = s.ToLower();
        string word = "";

        if (s.Length > 1)
        {
            foreach (var c in s)
            {
                if (Char.IsLetterOrDigit(c))
                {
                    word += c;
                }
            }
        }
        else
        {
            word = s;
        }

        Console.WriteLine(word);
        
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] != word[word.Length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
}
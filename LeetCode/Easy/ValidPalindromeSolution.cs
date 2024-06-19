namespace LeetCode.Easy;

public class ValidPalindromeSolution
{
    public static bool IsPalindrome(string s)
    {
        //TODO: Try with storing the start and end separately in two different vars
        
        string word = s.ToLower();
        int index = 0;
        int count = 0;

        Console.WriteLine(word);

        while (count < word.Length)
        {
            if (Char.IsLetterOrDigit(word[index]))
            {
                if (Char.IsLetterOrDigit(word[word.Length - 1 - index]))
                {
                    if (word[index] != word[word.Length - 1 - index])
                    {
                        return false;
                    }
                }
                else
                {
                    if (word[index] != word[word.Length - 1 - 1 - index])
                    {
                        return false;
                    }
                }

                index++;
            }

            count++;
        }

        return true;
    }
}
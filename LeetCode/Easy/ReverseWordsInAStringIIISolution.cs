namespace LeetCode.Easy;

public class ReverseWordsInAStringIIISolution
{
    public static string ReverseWords(string s)
    {
        string[] words = s.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            char[] letters = words[i].ToCharArray();
            for (int j = 0; j < words[i].Length / 2; j++)
            {
                (letters[j], letters[letters.Length - 1 - j]) = (letters[letters.Length - 1 - j], letters[j]);
            }

            words[i] = new string(letters);
        }

        return String.Join(" ", words);
    }
}
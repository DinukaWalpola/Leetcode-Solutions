namespace LeetCode.Easy;

public class ReversePrefixOfAWordSolution
{
    public static string ReversePrefix(string word, char ch)
    {
        char[] wordChar = word.ToCharArray();
        int index = word.IndexOf(ch);

        for (int i = 0; i < (index + 1) / 2; i++)
        {
            char temp = wordChar[i];
            wordChar[i] = word[index - i];
            wordChar[index - i] = temp;
        }

        return new String(wordChar);
    }
}
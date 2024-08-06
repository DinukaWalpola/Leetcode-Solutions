using System.Text;

namespace LeetCode.Easy;

public class TruncateStringSolution
{
    public static string TruncateSentence(string s, int k)
    {
        List<string> words = new List<string>();
        StringBuilder word = new StringBuilder();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
            {
                words.Add(word.ToString());
                word.Clear();
                continue;
            }

            if (words.Count == k)
            {
                break;
            }

            word.Append(s[i]);
        }
        
        if (!word.Equals("")) words.Add(word.ToString());

        return String.Join(" ", words);
    }
}
using System.Text;

namespace LeetCode.Easy;

public class TruncateStringSolution
{
    public static string TruncateSentence(string s, int k)
    {
        StringBuilder words = new StringBuilder();
        StringBuilder word = new StringBuilder();
        int wordCount = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
            {
                words.Append(word.ToString());
                word.Clear();
                wordCount++;
            }
            
            if (wordCount == k)
            {
                break;
            }
            
            word.Append(s[i]);
        }
        
        words.Append(word.ToString());

        return String.Join(" ", words);
    }
}
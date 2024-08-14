using System.Text;

namespace LeetCode.Easy;

public class FaultyKeyboardSolution
{
    public static string FinalString(string s)
    {
        StringBuilder sb = new StringBuilder();

        for(int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'i')
            {
                for (int j = 0; j < sb.Length / 2; j++)
                {
                    (sb[j], sb[sb.Length - 1 - j]) = (sb[sb.Length - 1 - j], sb[j]);
                }
                continue;
            }

            sb.Append(s[i]);
        }

        return sb.ToString();
    }
}
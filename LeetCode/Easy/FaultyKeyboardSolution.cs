using System.Text;

namespace LeetCode.Easy;

public class FaultyKeyboardSolution
{
    public static string FinalString(string s)
    {
        StringBuilder sb = new StringBuilder();

        foreach (var c in s)
        {
            if (c == 'i')
            {
                for (int i = 0; i < sb.Length / 2; i++)
                {
                    (sb[i], sb[sb.Length - 1 - i]) = (sb[sb.Length - 1 - i], sb[i]);
                }
                continue;
            }

            sb.Append(c);
        }

        return sb.ToString();
    }
}
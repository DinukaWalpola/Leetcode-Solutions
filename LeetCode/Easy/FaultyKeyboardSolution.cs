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
                char[] arr = sb.ToString().ToCharArray();
                for (int i = 0; i < arr.Length / 2; i++)
                {
                    (arr[i], arr[arr.Length - 1 - i]) = (arr[arr.Length - 1 - i], arr[i]);
                }

                sb.Clear();
                sb.Append(new String(arr));
                continue;
            }

            sb.Append(c);
        }

        return sb.ToString();
    }
}
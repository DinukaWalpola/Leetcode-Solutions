using System.Text;

namespace LeetCode.Easy;

public class ReplaceDigitsWithCharactersSolution
{
    public static string ReplaceDigits(string s)
    {
        char[] c = s.ToCharArray();
        int count = 0;

        for (int i = 0; i < c.Length / 2; i++)
        {
            c[count + 1] = Convert.ToChar(c[count] + int.Parse(c[count + 1].ToString()));
            count += 2;
        }

        return new string(c);
    }
}
namespace LeetCode.Easy;

public class ToLowerCaseSolution
{
    public static string ToLowerCase(string s)
    {
        var chars = s.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            if ((int) chars[i] is >= 65 and <= 90)
            {
                chars[i] = Convert.ToChar(((int)chars[i] + 32));
            }
        }

        return new string(chars);
    }
}
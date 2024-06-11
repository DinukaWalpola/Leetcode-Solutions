namespace LeetCode.Easy;

public static class ReverseStringSolution
{
    public static char[] ReverseString(char[] s) 
    {
        for (int i = 0; i < s.Length / 2; i++)
        {
            (s[i], s[s.Length - (i + 1)]) = (s[s.Length - (i + 1)], s[i]);
        }

        return s;
    }
}
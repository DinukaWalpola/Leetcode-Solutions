namespace LeetCode.Easy;

public static class ReverseStringSolution
{
    public static char[] ReverseString(char[] s) 
    {
        for (int i = 0; i < s.Length; i++)
        {
            // Check whether the length of the char array is an odd number or even
            // Then implement the required functionality based on them
            if (s.Length % 2 == 1)
            {
                int middle = s.Length / 2;
                if (i == middle)
                {
                    continue;
                }

                char temp = s[i];
                s[i] = s[s.Length - (i + 1)];
                s[s.Length - (i + 1)] = temp;
            }
        }

        return s;
    }
}
namespace LeetCode.Easy;

public class PermutationDifferenceBetweenTwoStringsSolution
{
    public static int FindPermutationDifference(string s, string t)
    {
        int sum = 0;

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j < t.Length; j++)
            {
                if (s[i] == t[j])
                {
                    sum += Math.Abs(i - j);
                    break;
                }
            }
        }

        return sum;
    }
}
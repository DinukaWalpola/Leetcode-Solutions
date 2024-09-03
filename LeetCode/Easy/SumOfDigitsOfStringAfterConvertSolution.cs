namespace LeetCode.Easy;

public class SumOfDigitsOfStringAfterConvertSolution
{
    public static int GetLucky(string s, int k)
    {
        int[] numericalValOfS = new int[s.Length];
        int sum = 0;

        for (int i = 0; i < s.Length; i++)
        {
            numericalValOfS[i] = s[i] - 96;
        }

        string convertedS = string.Join("", numericalValOfS);

        for (int i = 0; i < k; i++)
        {
            for (int j = 0; j < convertedS.Length; j++)
            {
                sum += int.Parse(convertedS[j].ToString());
            }

            convertedS = sum.ToString();
            sum = 0;
        }

        return int.Parse(convertedS);
    }
}
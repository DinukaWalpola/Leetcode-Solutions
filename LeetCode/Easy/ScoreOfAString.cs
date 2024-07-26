namespace LeetCode.Easy;

public class ScoreOfAString
{
    public static int ScoreOfString(string s) {
        int sum = 0;

        for (int i = 0; i < s.Length - 1; i++)
        {
            int localSum = s[i] - s[i + 1];
            sum += Math.Abs(localSum);
        }
        
        return sum;
    }
}
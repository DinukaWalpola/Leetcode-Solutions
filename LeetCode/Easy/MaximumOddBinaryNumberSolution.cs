namespace LeetCode.Easy;

public class MaximumOddBinaryNumberSolution
{
    public static string MaximumOddBinaryNumber(string s)
    {
        char[] digits = s.ToCharArray();
        List<int> indexOfOnes = new List<int>();

        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] == '1')
            {
                indexOfOnes.Add(i);
            }
        }

        if (indexOfOnes.Count > 1)
        {
            for (int i = 0; i < indexOfOnes.Count - 1; i++)
            {
                (digits[i], digits[indexOfOnes[i]]) = (digits[indexOfOnes[i]], digits[i]);
            }
        }
        
        (digits[^1], digits[indexOfOnes[^1]]) = (digits[indexOfOnes[^1]], digits[^1]);

        return new string(digits);
    }
}
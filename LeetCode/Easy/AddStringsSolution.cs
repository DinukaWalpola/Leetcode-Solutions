using System.Numerics;
using System.Text;

namespace LeetCode.Easy;

public class AddStringsSolution
{
    public static string AddStrings(string num1, string num2)
    {
        // try with a single loop that iterated through the length of the longest input(num1 or num2) 
        // then try adding them from the end of the string 
        // It will also have the same mechanism to maintain the 0s (10s, 100s, 1000s etc.) like this solution
        
        BigInteger numOne = 0;
        StringBuilder sb = new StringBuilder();
        BigInteger numTwo = 0;

        for (int i = 0; i < num1.Length; i++)
        {
            sb.Append(num1[i].ToString());
            sb.Append('0', num1.Length - 1 - i);
            numOne += BigInteger.Parse(sb.ToString());
            sb.Clear();
        }
        
        for (int i = 0; i < num2.Length; i++)
        {
            sb.Append(num2[i].ToString());
            sb.Append('0', num2.Length - 1 - i);
            numTwo += BigInteger.Parse(sb.ToString());
            sb.Clear();
        }

        return (numOne + numTwo).ToString();
    }
}
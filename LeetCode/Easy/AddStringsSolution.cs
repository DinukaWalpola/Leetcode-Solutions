using System.Numerics;
using System.Text;

namespace LeetCode.Easy;

public class AddStringsSolution
{
    public static string AddStrings(string num1, string num2)
    {
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
using System.Numerics;

namespace LeetCode.Easy;

public class AddStringsSolution
{
    public static string AddStrings(string num1, string num2)
    {
        BigInteger numOne = 0;
        // string sb1 = "";
        BigInteger numTwo = 0;
        // string numTwoStr = "";

        for (int i = 0; i < num1.Length; i++)
        {
            var numOneStr = num1[i].ToString();
            numOneStr += String.Concat(Enumerable.Repeat("0", num1.Length - 1 - i));
            numOne += BigInteger.Parse(numOneStr);
        }
        
        for (int i = 0; i < num2.Length; i++)
        {
            var numTwoStr = num2[i].ToString();
            numTwoStr += String.Concat(Enumerable.Repeat("0", num2.Length - 1 - i));
            numTwo += BigInteger.Parse(numTwoStr);
        }

        return (numOne + numTwo).ToString();
    }
}
using System.Text;

namespace LeetCode.Easy;

public class RemoveOuterMostParenthesesSolution
{
    public static string RemoveOuterParentheses(string s)
    {
        StringBuilder result = new StringBuilder();
        int parenthesesCount = 0;

        // We can try it with a single loop as well with 2 int variables to store start and end
        for (int i = 0; i < s.Length - 1; i++)
        {
            parenthesesCount++;
            for (int j = i + 1; j < s.Length; j++)
            {
                if (s[j] == ')')
                {
                    parenthesesCount--;
                }
                else
                {
                    parenthesesCount++; // Can add a continue here
                }

                if (parenthesesCount == 0)
                {
                    i = j;
                    break;
                }
                
                result.Append(s[j]);
            }
        }

        return result.ToString();
    }
}
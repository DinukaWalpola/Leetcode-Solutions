using System.Text;

namespace LeetCode.Easy;

public class RemoveOuterMostParenthesesSolution
{
    public static string RemoveOuterParentheses(string s)
    {
        StringBuilder result = new StringBuilder();
        int parenthesesCount = 0;
        int iterator = 0;
        
        do
        {
            if (s[iterator] == '(')
            {
                if (parenthesesCount > 0)
                {
                    result.Append(s[iterator]);
                }
                parenthesesCount++;
            }
            else
            {
                if (parenthesesCount > 1)
                {
                    result.Append(s[iterator]);
                }
                parenthesesCount--;
            }
            
            iterator++;

        } while (iterator < s.Length);

        return result.ToString();
    }
}
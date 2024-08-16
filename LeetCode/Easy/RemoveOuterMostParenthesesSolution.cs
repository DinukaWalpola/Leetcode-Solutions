using System.Text;

namespace LeetCode.Easy;

public class RemoveOuterMostParenthesesSolution
{
    public static string RemoveOuterParentheses(string s)
    {
        StringBuilder result = new StringBuilder();
        int parenthesesCount = 1;
        int iterator = 1;
        
        do
        {
            if (parenthesesCount == 0)
            {
                parenthesesCount++;
                iterator++;
                continue;
            }
            
            if (s[iterator] == '(')
            {
                parenthesesCount++;
            }
            else
            {
                parenthesesCount--;
            }
            
            if (parenthesesCount != 0)
            {
                result.Append(s[iterator]);
            }

            iterator++;

        } while (iterator < s.Length);

        return result.ToString();
    }
}
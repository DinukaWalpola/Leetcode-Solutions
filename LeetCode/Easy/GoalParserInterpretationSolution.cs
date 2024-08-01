using System.Text;

namespace LeetCode.Easy;

public class GoalParserInterpretationSolution
{
    public static string Interpret(string command)
    {
        StringBuilder letters = new StringBuilder();

        for (int i = 0; i < command.Length; i++)
        {
            if (command[i] == '(')
            {
                if (command[i + 1] == ')')
                {
                    letters.Append('o');
                    i++;
                }
                else
                {
                    letters.Append(command[i + 1]);
                    letters.Append(command[i + 2]);
                    i += 2;
                }
            }
            else
            {
                if (command[i] != ')')
                {
                    letters.Append(command[i]);
                }
            }
        }

        return String.Join("", letters);
    }
}
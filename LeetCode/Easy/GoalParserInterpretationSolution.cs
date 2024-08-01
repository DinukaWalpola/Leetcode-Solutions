namespace LeetCode.Easy;

public class GoalParserInterpretationSolution
{
    public static string Interpret(string command)
    {
        List<char> letters = new List<char>();

        for (int i = 0; i < command.Length; i++)
        {
            if (command[i] == '(')
            {
                if (command[i + 1] == ')')
                {
                    letters.Add('o');
                    i++;
                }
                else
                {
                    letters.Add(command[i + 1]);
                    letters.Add(command[i + 2]);
                    i += 2;
                }
            }
            else
            {
                if (command[i] != ')')
                {
                    letters.Add(command[i]);
                }
            }
        }

        return String.Join("", letters);
    }
}
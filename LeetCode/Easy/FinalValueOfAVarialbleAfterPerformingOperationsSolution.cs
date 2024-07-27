namespace LeetCode.Easy;

public class FinalValueOfAVarialbleAfterPerformingOperationsSolution
{
    public static int FinalValueAfterOperations(string[] operations)
    {
        int num = 0;

        foreach (var operation in operations)
        {
            if (operation[0] == '+' || operation[^1] == '+')
            {
                num++;
            }
            else
            {
                num--;
            }
        }
        return num;
    }
}
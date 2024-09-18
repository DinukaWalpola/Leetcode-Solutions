namespace LeetCode.Easy;

public class CrawlerLogFolderSolution
{
    public static int MinOperations(string[] logs)
    {
        int minNumOfOperations = 0;

        for (int i = 0; i < logs.Length; i++)
        {
            if (logs[i].Equals("../"))
            {
                if (minNumOfOperations > 0)
                {
                    minNumOfOperations--;
                }
            }
            else if (!logs[i].Equals("./"))
            {
                minNumOfOperations++;
            }
        }

        return minNumOfOperations;
    }
}
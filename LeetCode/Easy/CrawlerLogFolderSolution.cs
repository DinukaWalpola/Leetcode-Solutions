namespace LeetCode.Easy;

public class CrawlerLogFolderSolution
{
    public static int MinOperations(string[] logs)
    {
        int minNumOfOperations = 0;

        for (int i = 0; i < logs.Length; i++)
        {
            if (logs[i].Equals("./") || (minNumOfOperations == 0 && logs[i].Equals("../")))
            {
                continue;
            }
            
            if (logs[i].Equals("../"))
            {
                minNumOfOperations--;
                continue;
            }
            
            minNumOfOperations++;
        }

        return minNumOfOperations;
    }
}
namespace LeetCode.Easy;

public class FindMaxNumberOfStringPairsSolution
{
    public static int MaximumNumberOfStringPairs(string[] words)
    {
        int pairsCount = 0;
        string reversedWord;

        for (int i = 0; i < words.Length - 1; i++)
        {
            reversedWord = $"{words[i][1]}{words[i][0]}";
            for (int j = i + 1; j < words.Length; j++)
            {
                if (reversedWord == words[j])
                {
                    pairsCount++;
                }
            }
        }

        return pairsCount;
    }
}
namespace LeetCode.Easy;

public class CountPairsOfSimilarWordsSolution
{
    public static int SimilarPairs(string[] words)
    {
        int pairCount = 0;
        List<char> first;
        List<char> second;
        bool isSimilar;

        for (int i = 0; i < words.Length; i++)
        {
            first = words[i].ToCharArray().Distinct().ToList();
            for (int j = i + 1; j < words.Length; j++)
            {
                isSimilar = true;
                second = words[j].ToCharArray().Distinct().ToList();

                if (first.Count != second.Count)
                {
                    continue;
                }

                for (int k = 0; k < first.Count; k++)
                {
                    if (!first.Contains(second[k]))
                    {
                        isSimilar = false;
                        break;
                    }
                }
                
                if (isSimilar)
                {
                    pairCount++;
                }
            }
        }

        return pairCount;
    }
}
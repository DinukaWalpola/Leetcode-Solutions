namespace LeetCode.Easy;

public class CountPairsOfSimilarWordsSolution
{
    public static int SimilarPairs(string[] words)
    {
        int pairCount = 0;

        for (int i = 0; i < words.Length; i++)
        {
            var first = words[i].ToCharArray().Distinct().ToList();
            for (int j = i + 1; j < words.Length; j++)
            {
                var isSimilar = true;
                var second = words[j].ToCharArray().Distinct().ToList();

                if (first.Count != second.Count)
                {
                    continue;
                }

                first.Sort();
                second.Sort();

                if (!string.Join("", first).Equals(string.Join("", second)))
                {
                    isSimilar = false;
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
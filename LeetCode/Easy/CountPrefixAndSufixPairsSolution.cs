namespace LeetCode.Easy;

public class CountPrefixAndSufixPairsSolution
{
    public static int CountPrefixSuffixPairs(string[] words)
    {
        int prefixAndSufixCount = 0;

        for (int i = 0; i < words.Length; i++)
        {
            for (int j = i + 1; j < words.Length; j++)
            {
                if (words[i].Length <= words[j].Length)
                {
                    if (words[j].Substring(0, words[i].Length).Equals(words[i]) && words[j].Substring(words[j].Length - words[i].Length).Equals(words[i]))
                    {
                        prefixAndSufixCount++;
                    }
                }
            }
        }

        return prefixAndSufixCount;
    }
}
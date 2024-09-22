namespace LeetCode.Easy;

public class StringMatchingInAnArraySolution
{
    public static IList<string> StringMatching(string[] words)
    {
        List<string> matchingStrings = new List<string>();

        for (int i = 0; i < words.Length; i++)
        {
            for (int j = 0; j < words.Length; j++)
            {
                if (words[i].Equals(words[j])) continue;

                if (words[j].Contains(words[i]))
                {
                    matchingStrings.Add(words[i]);
                    break;
                }
            }
        }

        return matchingStrings;
    }
}
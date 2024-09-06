namespace LeetCode.Easy;

public class CountingWordsWithAGivenPrefixSolution
{
    public static int PrefixCount(string[] words, string pref)
    {
        int count = 0;

        for (int i = 0; i < words.Length; i++)
        {
            if (pref.Length > words[i].Length) continue;

            if (words[i].Substring(0, pref.Length).Equals(pref)) count++;
        }

        return count;
    }
}
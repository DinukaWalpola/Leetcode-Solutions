namespace LeetCode.Easy;

public class CountingWordsWithAGivenPrefixSolution
{
    public static int PrefixCount(string[] words, string pref)
    {
        int count = 0;
        bool isMatching = true;

        for (int i = 0; i < words.Length; i++)
        {
            if (pref.Length > words[i].Length) continue;
            
            for (int j = 0; j < pref.Length; j++)
            {
                if (words[i][j] != pref[j])
                {
                    isMatching = false;
                    break;
                }
            }

            if (isMatching)
            {
                count++;
            }

            isMatching = true;
        }

        return count;
    }
}
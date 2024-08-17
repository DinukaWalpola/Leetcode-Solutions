namespace LeetCode.Easy;

public class CountTheNumberOfConsistentStringsSolution
{
    public static int CountConsistentStrings(string allowed, string[] words)
    {
        int consistentWordCount = 0;
        bool isConsistent;

        foreach (var word in words)
        {
            isConsistent = true;
            foreach (var c in word)
            {
                if (!allowed.Contains(c))
                {
                    isConsistent = false;
                    break;
                }
            }

            if (isConsistent) consistentWordCount++;
        }

        return consistentWordCount;
    }
}
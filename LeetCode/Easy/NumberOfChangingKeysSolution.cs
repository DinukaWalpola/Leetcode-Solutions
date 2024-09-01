namespace LeetCode.Easy;

public class NumberOfChangingKeysSolution
{
    public static int CountKeyChanges(string s)
    {
        int keysChangedCount = 0;
        (int, int) asciiValOfCurrentKeys = s[0] >= 97 ? (s[0], s[0] - 32) : (s[0] + 32, s[0]);

        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] >= 97)
            {
                if (s[i] != asciiValOfCurrentKeys.Item1)
                {
                    keysChangedCount++;
                    asciiValOfCurrentKeys.Item1 = s[i];
                    asciiValOfCurrentKeys.Item2 = s[i] - 32;
                }
            }
            else
            {
                if (s[i] != asciiValOfCurrentKeys.Item2)
                {
                    keysChangedCount++;
                    asciiValOfCurrentKeys.Item2 = s[i];
                    asciiValOfCurrentKeys.Item1 = s[i] + 32;
                }
            }
        }

        return keysChangedCount;
    }
}
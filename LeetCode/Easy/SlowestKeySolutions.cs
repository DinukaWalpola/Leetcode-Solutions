namespace LeetCode.Easy;

public class SlowestKeySolutions
{
    public static char SlowestKey(int[] releaseTimes, string keysPressed)
    {
        int maxGap = releaseTimes[0];
        int maxGapIndex = 0;

        for (int i = 1; i < releaseTimes.Length; i++)
        {
            if (releaseTimes[i] - releaseTimes[i - 1] > maxGap)
            {
                maxGap = releaseTimes[i] - releaseTimes[i - 1];
                maxGapIndex = i;
            }
            else if (keysPressed[i] > keysPressed[maxGapIndex] && maxGap == releaseTimes[i] - releaseTimes[i - 1])
            {
                maxGapIndex = i;
            }
        }

        return keysPressed[maxGapIndex];
    }
}
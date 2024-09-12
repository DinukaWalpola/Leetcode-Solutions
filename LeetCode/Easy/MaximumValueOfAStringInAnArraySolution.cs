namespace LeetCode.Easy;

public class MaximumValueOfAStringInAnArraySolution
{
    public static int MaximumValue(string[] strs)
    {
        int maxVal = 0;
        bool isOnlyNum;

        for (int i = 0; i < strs.Length; i++)
        {
            isOnlyNum = true;
            for (int j = 0; j < strs[i].Length; j++)
            {
                if (!char.IsNumber(strs[i][j]))
                {
                    isOnlyNum = false;
                }
            }

            if (isOnlyNum)
            {
                if (int.Parse(strs[i]) > maxVal)
                {
                    maxVal = int.Parse(strs[i]);
                }
            }
            else
            {
                if (strs[i].Length > maxVal)
                {
                    maxVal = strs[i].Length;
                }
            }
            
        }

        return maxVal;
    }
}
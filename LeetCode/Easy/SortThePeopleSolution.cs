namespace LeetCode.Easy;

public class SortThePeopleSolution
{
    public static string[] SortPeople(string[] names, int[] heights) {
        for (int i = 0; i < heights.Length - 1; i++)
        {
            for (int j = i + 1; j < heights.Length; j++)
            {
                if (heights[i] < heights[j])
                {
                    (names[i], names[j]) = (names[j], names[i]);
                    (heights[i], heights[j]) = (heights[j], heights[i]);
                }
                
            }
        }

        return names;
    }
}
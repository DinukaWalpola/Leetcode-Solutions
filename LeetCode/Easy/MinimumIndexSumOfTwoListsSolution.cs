namespace LeetCode.Easy;

public class MinimumIndexSumOfTwoListsSolution
{
    public static string[] FindRestaurant(string[] list1, string[] list2)
    {
        List<string> minIndex = new List<string>();
        int min = int.MaxValue;

        for (int i = 0; i < list1.Length; i++)
        {
            for (int j = 0; j < list2.Length; j++)
            {
                if (list1[i].Equals(list2[j]))
                {
                    if (i + j < min)
                    {
                        minIndex.Clear();
                        min = i + j;
                        minIndex.Add(list1[i]);
                    }
                    else if (i + j == min)
                    {
                        minIndex.Add(list1[i]);
                    }
                    break;
                }
            }
        }

        return minIndex.ToArray();
    }
}
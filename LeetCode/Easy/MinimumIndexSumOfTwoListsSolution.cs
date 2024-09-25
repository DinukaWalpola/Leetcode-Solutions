namespace LeetCode.Easy;

public class MinimumIndexSumOfTwoListsSolution
{
    public static string[] FindRestaurant(string[] list1, string[] list2)
    {
        Dictionary<string, int> duplicates = new Dictionary<string, int>();
        List<string> minIndex = new List<string>();

        for (int i = 0; i < list1.Length; i++)
        {
            for (int j = 0; j < list2.Length; j++)
            {
                if (list1[i].Equals(list2[j]))
                {
                    duplicates.Add(list1[i], i + j);
                    break;
                }
            }
        }

        int min = duplicates.Values.First();
        minIndex.Add(duplicates.Keys.First());

        for (int i = 1; i < duplicates.Values.Count; i++)
        {
            if (duplicates.ElementAt(i).Value < min)
            {
                minIndex.Clear();
                min = duplicates.ElementAt(i).Value;
                minIndex.Add(duplicates.ElementAt(i).Key);
            }
            else if (duplicates.ElementAt(i).Value == min)
            {
                minIndex.Add(duplicates.ElementAt(i).Key);
            }
        }

        return minIndex.ToArray();
    }
}
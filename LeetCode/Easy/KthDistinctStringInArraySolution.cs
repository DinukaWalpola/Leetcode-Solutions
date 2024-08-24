namespace LeetCode.Easy;

public class KthDistinctStringInArraySolution
{
    public static string KthDistinct(string[] arr, int k)
    {
        List<string> distinctStrings = new List<string>();
        Dictionary<int, string> duplicates = new Dictionary<int, string>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (duplicates.ContainsValue(arr[i])) continue;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (duplicates.ContainsKey(j)) continue;
                if (arr[i] == arr[j])
                {
                    duplicates.Add(j, arr[i]);
                    break;
                }
            }

            if (!duplicates.ContainsValue(arr[i]))
            {
                distinctStrings.Add(arr[i]);
            }
        }

        return (k-1) < distinctStrings.Count ? distinctStrings[k-1] : "";
    }
}
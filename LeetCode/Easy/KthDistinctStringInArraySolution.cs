namespace LeetCode.Easy;

public class KthDistinctStringInArraySolution
{
    public static string KthDistinct(string[] arr, int k)
    {
        List<string> distinctStrings = new List<string>();
        List<string> duplicateStrings = new List<string>();
        List<int> duplicateIndexes = new List<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (duplicateStrings.Contains(arr[i])) continue;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (duplicateIndexes.Contains(j)) continue;
                if (arr[i] == arr[j])
                {
                    duplicateStrings.Add(arr[i]);
                    duplicateIndexes.Add(j);
                    break;
                }
            }

            if (!duplicateStrings.Contains(arr[i]))
            {
                distinctStrings.Add(arr[i]);
            }
        }

        return (k-1) < distinctStrings.Count ? distinctStrings[k-1] : "";
    }
}
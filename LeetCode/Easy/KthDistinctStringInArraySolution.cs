namespace LeetCode.Easy;

public class KthDistinctStringInArraySolution
{
    public static string KthDistinct(string[] arr, int k)
    {
        List<string> distinctStrings = new List<string>();
        List<string> duplicateStrings = new List<string>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (!duplicateStrings.Contains(arr[i]))
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        duplicateStrings.Add(arr[i]);
                        break;
                    }
                }

                if (!duplicateStrings.Contains(arr[i]))
                {
                    distinctStrings.Add(arr[i]);
                }
            }
        }

        if (distinctStrings.Count >= k)
        {
            return distinctStrings[k - 1];
        }

        return "";
    }
}
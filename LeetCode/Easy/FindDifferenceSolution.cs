namespace LeetCode.Easy;

public class FindDifferenceSolution
{
    public static char FindTheDifference(string s, string t)
    {
        List<int> duplicateIndexes = new List<int>();
        for (int i = 0; i < t.Length; i++)
        {
            bool isUnique = true;
            
            for (int j = 0; j < s.Length; j++)
            {
                if (!duplicateIndexes.Contains(j) && t[i].Equals(s[j]))
                {
                    duplicateIndexes.Add(j);
                    isUnique = false;
                    break;
                }
            }

            if (isUnique) return t[i];

        }

        return ' ';
    }
}
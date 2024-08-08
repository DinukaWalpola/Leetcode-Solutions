namespace LeetCode.Easy;

public class ShuffleStringSolution
{
    public static string RestoreString(string s, int[] indices)
    {
        char[] properlyIndexedArr = new char[s.Length];

        for (int i = 0; i < indices.Length; i++)
        {
            properlyIndexedArr[indices[i]] = s[i];
        }

        return new string(properlyIndexedArr);
    }
}
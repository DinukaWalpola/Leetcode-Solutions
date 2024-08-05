namespace LeetCode.Easy;

public class CheckIfTwoStringArraysAreEquivalentSolution
{
    public static bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        string w1 = String.Join("", word1);
        string w2 = String.Join("", word2);

        if (w1.Length != w2.Length) return false;

        char[] arr1 = w1.ToCharArray();
        char[] arr2 = w2.ToCharArray();

        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                return false;
            }
        }

        return true;
    }
}
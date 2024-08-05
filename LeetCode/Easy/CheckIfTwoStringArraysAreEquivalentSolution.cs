namespace LeetCode.Easy;

public class CheckIfTwoStringArraysAreEquivalentSolution
{
    public static bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        string w1 = String.Join("", word1);
        string w2 = String.Join("", word2);

        if (w1.Equals(w2)) return true;

        return false;
    }
}
namespace LeetCode.Easy;

public class FindWordsContainingCharacterSolution
{
    public static IList<int> FindWordsContaining(string[] words, char x)
    {
        List<int> indexes = new List<int>();

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Contains(x)) indexes.Add(i);
        }

        return indexes;
    }
}
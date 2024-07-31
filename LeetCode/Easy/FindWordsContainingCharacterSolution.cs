namespace LeetCode.Easy;

public class FindWordsContainingCharacterSolution
{
    public static IList<int> FindWordsContaining(string[] words, char x)
    {
        List<int> indexes = new List<int>();

        for (int i = 0; i < words.Length; i++)
        {
            foreach (var c in words[i])
            {
                if (x == c)
                {
                    indexes.Add(i);
                    break;
                }
            }
        }

        return indexes;
    }
}
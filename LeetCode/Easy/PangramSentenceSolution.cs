namespace LeetCode.Easy;

public class PangramSentenceSolution
{
    public static bool CheckIfPangram(string sentence)
    {
        List<char> characters = new List<char>();

        foreach (var c in sentence)
        {
            if (!characters.Contains(c))
            {
                characters.Add(c);
                
                if (characters.Count == 26)
                {
                    return true;
                }
            }
        }

        return false;
    }
}
namespace LeetCode.Easy;

public class SplitStringsBySeparatorSolution
{
    public static IList<string> SplitWordsBySeparator(IList<string> words, char separator)
    {
        List<string> separatedWords = new List<string>();
        List<char> currentWord = new List<char>();

        for (int i = 0; i < words.Count; i++)
        {
            for (int j = 0; j < words[i].Length; j++)
            {
                if (words[i][j] == separator)
                {
                    if (currentWord.Count > 0)
                    {
                        separatedWords.Add(string.Join("", currentWord));
                        currentWord.Clear();
                    }
                    continue;
                }
                currentWord.Add(words[i][j]);
            }

            if (currentWord.Count > 0)
            {
                separatedWords.Add(string.Join("", currentWord));
                currentWord.Clear();
            }
        }

        return separatedWords;
    }
}
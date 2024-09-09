using System.Text;

namespace LeetCode.Easy;

public class SplitStringsBySeparatorSolution
{
    public static IList<string> SplitWordsBySeparator(IList<string> words, char separator)
    {
        List<string> separatedWords = new List<string>();
        StringBuilder currentWord = new StringBuilder();

        for (int i = 0; i < words.Count; i++)
        {
            for (int j = 0; j < words[i].Length; j++)
            {
                if (words[i][j] == separator || j == words[i].Length - 1)
                {
                    if (j == words[i].Length - 1 && words[i][j] != separator) currentWord.Append(words[i][j]);
                    if (currentWord.Length > 0)
                    {
                        separatedWords.Add(currentWord.ToString());
                        currentWord.Clear();
                    }
                    continue;
                }
                currentWord.Append(words[i][j]);
            }
        }

        return separatedWords;
    }
}
namespace LeetCode.Easy;

public class OddStringDifferenceSolution
{
    public static string OddString(string[] words)
    {
        int[] firstWord = new int [words[0].Length - 1];
        int[] lastWord = new int [words[0].Length - 1];
        int[] difference = new int [words[0].Length - 1];
        
        for (int j = 0; j < words[0].Length - 1; j++)
        {
            firstWord[j] = words[0][j + 1] - words[0][j];
            lastWord[j] = words[^1][j + 1] - words[^1][j];
        }

        for (int i = 1; i < words.Length - 1; i++)
        {
            for (int j = 0; j < words[i].Length - 1; j++)
            {
                difference[j] = words[i][j + 1] - words[i][j];
            }

            if (!difference.SequenceEqual(firstWord) && !difference.SequenceEqual(lastWord))
            {
                return words[i];
            }
            
            if (!difference.SequenceEqual(firstWord) && difference.SequenceEqual(lastWord))
            {
                return words[0];
            }
            
            if (difference.SequenceEqual(firstWord) && !difference.SequenceEqual(lastWord))
            {
                return words[^1];
            }
        }

        return "";
    }
}
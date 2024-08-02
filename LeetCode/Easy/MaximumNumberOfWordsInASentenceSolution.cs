namespace LeetCode.Easy;

public class MaximumNumberOfWordsInASentenceSolution
{
    public static int MostWordsFound(string[] sentences)
    {
        int wordCount = 0;
        
        foreach (var sentence in sentences)
        {
            var words = sentence.Split(" ");

            if (words.Length > wordCount)
            {
                wordCount = words.Length;
            }
        }

        return wordCount;
    }
}
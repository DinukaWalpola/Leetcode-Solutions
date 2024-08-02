namespace LeetCode.Easy;

public class MaximumNumberOfWordsInASentenceSolution
{
    public static int MostWordsFound(string[] sentences)
    {
        int wordCount = 0;

        // foreach (var sent in sentences)
        // {
        //     int currentWordCount = 0;
        //
        //     for (int i = 0; i < sent.Length; i++)
        //     {
        //         if (sent[i] == ' ' || i == sent.Length - 1)
        //         {
        //             currentWordCount++;
        //         }
        //     }
        //
        //     if (currentWordCount > wordCount)
        //     {
        //         wordCount = currentWordCount;
        //     }
        // }
        
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
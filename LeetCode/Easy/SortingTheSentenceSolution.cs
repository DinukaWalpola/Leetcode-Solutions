using System.Text;

namespace LeetCode.Easy;

public class SortingTheSentenceSolution
{
    public static string SortSentence(string s)
    {
        List<char> letters = new List<char>();
        string[] sortedSentence;
        Dictionary<int, string> wordDictionary = new Dictionary<int, string>();

        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] == ' ')
            {
                double indexVal = Char.GetNumericValue(letters.Last());
                int index = Convert.ToInt32(indexVal);
                letters.RemoveAt(letters.Count - 1);
                wordDictionary.Add(index, string.Join("", letters));
                letters.Clear();
                continue;
            }
            
            letters.Add(s[i]);
        }
        
        wordDictionary.Add(Convert.ToInt32(Char.GetNumericValue(s[^1])), string.Join("", letters));
        
        sortedSentence = new string[wordDictionary.Count];
        
        foreach (var keyValuePair in wordDictionary)
        {
            sortedSentence[keyValuePair.Key - 1] = keyValuePair.Value;
        }

        return string.Join(" ", sortedSentence);
    }
}
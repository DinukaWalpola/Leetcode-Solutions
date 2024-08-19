using System.Text;

namespace LeetCode.Easy;

public class SortingTheSentenceSolution
{
    public static string SortSentence(string s)
    {
        Stack<string> words = new Stack<string>();
        Stack<int> wordIndexes = new Stack<int>();
        List<char> letters = new List<char>();
        string[] sortedSentence;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
            {
                double indexVal = Char.GetNumericValue(letters.Last());
                int index = Convert.ToInt32(indexVal);
                letters.RemoveAt(letters.Count - 1);
                // sortedSentence.Insert(index - 1, string.Join("", letters));
                words.Push(string.Join("", letters));
                wordIndexes.Push(index);
                letters.Clear();
                continue;
            }
            else if (i == s.Length - 1)
            {
                double indexVal = Char.GetNumericValue(s[i]);
                int index = Convert.ToInt32(indexVal);
                words.Push(string.Join("", letters));
                wordIndexes.Push(index);
                break;
            }
            letters.Add(s[i]);
        }

        sortedSentence = new string[words.Count];
        
        foreach (var ind in wordIndexes)
        {
            sortedSentence[ind - 1] = words.Pop();
        }

        return string.Join(" ", sortedSentence);
    }
}
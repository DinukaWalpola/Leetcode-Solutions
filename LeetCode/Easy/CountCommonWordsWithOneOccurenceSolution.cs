namespace LeetCode.Easy;

public class CountCommonWordsWithOneOccurenceSolution
{
    public static int CountWords(string[] words1, string[] words2)
    {
        List<string> uniques1 = new List<string>();
        List<string> uniques2 = new List<string>();
        List<string> finalUnique = new List<string>();
        bool isUnique;
        int uniqueCount;
        

        for (int i = 0; i < words1.Length; i++)
        {
            isUnique = true;
            
            for (int j = 0; j < words1.Length; j++)
            {
                if (i == j)
                {
                    continue;
                }
                
                if (words1[i].Equals(words1[j]))
                {
                    isUnique = false;
                    break;
                }
            }
            
            if (isUnique)
            {
                uniques1.Add(words1[i]);
            }
        }
        
        for (int i = 0; i < words2.Length; i++)
        {
            isUnique = true;
            
            for (int j = 0; j < words2.Length; j++)
            {
                if (i == j)
                {
                    continue;
                }
                
                if (words2[i].Equals(words2[j]))
                {
                    isUnique = false;
                    break;
                }
            }
            
            if (isUnique)
            {
                uniques2.Add(words2[i]);
            }
        }

        for (int i = 0; i < uniques1.Count; i++)
        {
            uniqueCount = 0;
            for (int j = 0; j < uniques2.Count; j++)
            {
                if (uniques1[i].Equals(uniques2[j]))
                {
                    uniqueCount++;
                }
            }

            if (uniqueCount == 1)
            {
                finalUnique.Add(uniques1[i]);
            }
        }

        return finalUnique.Count;
    }
}
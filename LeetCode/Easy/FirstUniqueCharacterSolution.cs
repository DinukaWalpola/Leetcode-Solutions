namespace LeetCode.Easy;

public class FirstUniqueCharacterSolution
{
    public static int FirstUniqChar(string s)
    {
        List<char> duplicates = new List<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (duplicates.Contains(s[i]))
            {
                continue; 
            }
            
            for (int j = i + 1; j < s.Length; j++)
            {
                if (s[i] == s[j])
                {
                    duplicates.Add(s[i]);
                    break;
                }
            }

            if (!duplicates.Contains(s[i]))
            {
                return i; 
            }
        }

        return -1;
    }
}
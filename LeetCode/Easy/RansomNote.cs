namespace LeetCode.Easy;

public class RansomNote
{
    public static bool CanConstruct(string ransomNote, string magazine)
    {
        List<char> list = new List<char>(ransomNote);
        int count = 0;

        foreach (var m in magazine)
        {
            if (list.Remove(m))
            {
                count++;
            }
        }
        
        
        return count == ransomNote.Length;
    }
}
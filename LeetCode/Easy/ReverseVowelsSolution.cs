namespace LeetCode.Easy;

public class ReverseVowelsSolution
{
    public static string ReverseVowels(string x)
    {
        var s = x.ToCharArray();
        char[] totalVowels = { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };
        var includedVowels = new List<int>();
        var count = 0;

        for (int i = 0; i < s.Length / 2; i++)
        {
            if (totalVowels.Contains(s[i]))
            {
                includedVowels.Add(i);
            }
        }

        for (int i = s.Length / 2; i < s.Length; i++)
        {
            if (totalVowels.Contains(s[i]))
            {
                var temp = s[i];
                s[i] = s[includedVowels[count]];
                s[includedVowels[0]] = temp;
                count++;
            }
        }

        x = String.Join("", s);

        return x;
    }
}
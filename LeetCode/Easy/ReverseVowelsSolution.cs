namespace LeetCode.Easy;

public class ReverseVowelsSolution
{
    public static string ReverseVowels(string s)
    {
        var sCharArr = s.ToCharArray();
        char[] totalVowels = { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };
        var includedVowels = new List<int>();
        var count = 1;

        for (int i = 0; i < sCharArr.Length; i++)
        {
            if (totalVowels.Contains(sCharArr[i]))
            {
                includedVowels.Add(i);
            }
        }

        for (int i = 0; i < includedVowels.Count / 2; i++)
        {
            var temp = sCharArr[includedVowels[i]];
            sCharArr[includedVowels[i]] = sCharArr[includedVowels[^count]];
            sCharArr[includedVowels[^count]] = temp;
            count++;
        }

        s = new string(sCharArr);

        return s;
    }
}
namespace LeetCode.Easy;

public class ReverseVowelsSolution
{
    public static string ReverseVowels(string s)
    {
        var sCharArr = s.ToCharArray();
        char[] totalVowels = { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };
        var includedVowels = new List<int>();
        var count = 0;

        for (int i = 0; i < sCharArr.Length / 2; i++)
        {
            if (totalVowels.Contains(sCharArr[i]))
            {
                includedVowels.Add(i);
            }
        }

        for (int i = sCharArr.Length / 2; i < sCharArr.Length; i++)
        {
            if (totalVowels.Contains(sCharArr[i]))
            {
                var temp = sCharArr[i];
                sCharArr[i] = sCharArr[includedVowels[includedVowels.Count - (1 + count)]];
                sCharArr[includedVowels[includedVowels.Count - (1 + count)]] = temp;
                count++;
            }
        }

        s = String.Join("", sCharArr);

        return s;
    }
}
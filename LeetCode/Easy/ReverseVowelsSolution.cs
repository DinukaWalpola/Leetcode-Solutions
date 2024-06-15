namespace LeetCode.Easy;

public class ReverseVowelsSolution
{
    public static string ReverseVowels(string s)
    {
        var sCharArr = s.ToCharArray();
        char[] totalVowels = { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };
        var stackVowels = new Stack<int>();
        var queueVowels = new Queue<int>();

        for (int i = 0; i < sCharArr.Length; i++)
        {
            if (totalVowels.Contains(sCharArr[i]))
            {
                stackVowels.Push(i);
                queueVowels.Enqueue(i);
            }
        }

        for (int i = 0; i < stackVowels.Count / 2; i++)
        {
            var temp = sCharArr[queueVowels.Peek() - i];
            sCharArr[queueVowels.Peek() - i] = sCharArr[stackVowels.Peek() - i];
            sCharArr[stackVowels.Peek() - i] = temp;
            // stackVowels.Pop();
            // queueVowels.Dequeue();
        }

        s = new string(sCharArr);

        return s;
    }
}
using System.Text;

namespace LeetCode.Easy;

public class DecryptStringFromAlphToIntMapSolution
{
    public static string FreqAlphabets(string s)
    {
        int count = 0;
        string num = "";
        Stack<char> letters = new Stack<char>();

        for (int i = s.Count() - 1; i >= 0; i--)
        {
            if (s[i] == '#')
            {
                if (num.Length > 0)
                {
                    var n = num.Reverse().ToArray();
                    var c1 = Convert.ToChar((int.Parse(new string(n[0].ToString())) + 96));
                    if (n.Length == 2)
                    {
                        var c2 = Convert.ToChar((int.Parse(new string(n[1].ToString())) + 96));
                        letters.Push(c2);
                    }
                    letters.Push(c1);
                    num = "";
                    count = 0;
                }
                
                num += s[i - 2];
                num += s[i - 1];

                var c = Convert.ToChar((int.Parse(num) + 96));
                letters.Push(c);

                num = "";
                count = 0;

                if (i >= 2)
                {
                    i--;
                    i--;
                }
                // else if (i - 2)
                
                continue;
            }

            count++;
            num += s[i];

            if (count == 2 || i == 0)
            {
                var n = num.Reverse().ToArray();
                var c1 = Convert.ToChar((int.Parse(new string(n[0].ToString())) + 96));
                if (n.Length == 2)
                {
                    var c2 = Convert.ToChar((int.Parse(new string(n[1].ToString())) + 96));
                    letters.Push(c2);
                }
                letters.Push(c1);
                num = "";
                count = 0;
            }
        }

        return new string(letters.ToArray());
    }
}
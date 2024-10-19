namespace LeetCode.Easy;

public class RomanToIntegerSolution
{
    public static int RomanToInt(string s)
    {
        Dictionary<char, int> romanChars = new Dictionary<char, int>
        {
            ['I'] = 1,
            ['V'] = 5,
            ['X'] = 10,
            ['L'] = 50,
            ['C'] = 100,
            ['D'] = 500,
            ['M'] = 1000
        };
        int previous = romanChars[s[^1]];
        int finalInt = previous;

        for (int i = s.Length - 2; i >= 0; i--)
        {
            if (romanChars[s[i]] >= previous)
            {
                finalInt += romanChars[s[i]];
                previous = romanChars[s[i]];
            }
            else
            {
                finalInt -= romanChars[s[i]];
            }
        }

        return finalInt;
    }
}
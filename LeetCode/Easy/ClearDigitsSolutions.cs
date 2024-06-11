namespace LeetCode.Easy;

public static class ClearDigitsSolutions
{
    public static string ClearDigits(string s)
    {
        // Console.WriteLine(s);
        // char[] letters = s.ToCharArray();
        var w = s;
        char[] nums = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        for (int i = 0; i < s.Length; i++)
        {
            if (nums.Contains(s.ToCharArray()[i]))
            {
                w = w.Replace(s.ToCharArray()[i].ToString(), "");
                // Console.WriteLine(s);
                // Console.WriteLine(w.Length);
                // Console.WriteLine(s.ToCharArray()[i].ToString());
                w = w.Replace(s.ToCharArray()[i-1].ToString(), "");
                // Console.WriteLine(s);
                // Console.WriteLine(s.Length);
            }
        }

        return w;
    }
}
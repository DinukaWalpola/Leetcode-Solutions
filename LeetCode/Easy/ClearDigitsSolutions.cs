namespace LeetCode.Easy;

public static class ClearDigitsSolutions
{
    public static string ClearDigits(string s)
    {
        var w = s;
        char[] nums = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        int count = 0;
        
        do
        {
            if (nums.Contains(w.ToCharArray()[count]))
            {
                w = w.Replace(w.ToCharArray()[count].ToString(), "");
                w = w.Replace(w.ToCharArray()[count-1].ToString(), "");
                count -= 2;
            }
            count++;

            // if (count == 0)
            // {
            //     break;
            // }
            
        } while (count < s.Length && count > 0);

        return w;
    }
}
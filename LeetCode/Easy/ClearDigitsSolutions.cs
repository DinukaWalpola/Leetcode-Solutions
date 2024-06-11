namespace LeetCode.Easy;

public static class ClearDigitsSolutions
{
    public static string ClearDigits(string s)
    {
        int count = 0;
        
        do
        {
            if (Char.IsDigit(s.ToCharArray()[count]))
            {
                s = s.Remove(count, 1);
                s = s.Remove(count - 1, 1);
                count -= 2;

                if (count == 0 && s.Length < 1)
                {
                    break;
                }
            }
            count++;
            
        } while (count < s.Length && s.Length != 0);

        return s;
    }
}
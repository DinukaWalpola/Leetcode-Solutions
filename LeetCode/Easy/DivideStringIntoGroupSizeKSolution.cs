namespace LeetCode.Easy;

public class DivideStringIntoGroupSizeKSolution
{
    public static string[] DivideString(string s, int k, char fill) {
        // Use a for loop, inside of it use a int var starting from 0 in each 
        // iteration, then add the character into the correct str set 
        string divided = "";
        int iterator = 0;
        string current = "";
        int count = 0;

        do
        {
            if (count < k)
            {
                // if (!divided.Contains(s[iterator]) && !current.Contains(s[iterator])) // remove the condition after &&
                // {
                    current += s[iterator];
                    count++;
                // }
            }
            
            // I think this is the place misfire happens
            if (count >= k && current.Length == k)
            {
                // if (current.Length < k)
                // {
                //     string matchup = new string (fill, k - current.Length);
                //     current += matchup;
                // }
                divided += $"{current} ";
                current = "";
                count = 0;
                // iterator -= 2;
            }

            if (iterator == s.Length - 1 && current.Length > 0)
            {
                if (current.Length < k)
                {
                    string matchup = new string (fill, k - current.Length);
                    current += matchup;
                }
                divided += $"{current} ";
                break;
            }

            iterator++;
        } while (iterator < s.Length);

        divided = divided.TrimEnd();

        return divided.Split(" ");

    }
}
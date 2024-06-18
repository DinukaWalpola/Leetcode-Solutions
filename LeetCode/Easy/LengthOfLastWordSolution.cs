namespace LeetCode.Easy;

public class LengthOfLastWordSolution
{
    public static int LengthOfLastWord(string s) {
        // Try using a for loop (initial thought was nested loops)
        // Create a string var outside the for loops to store the maximum length
        // then compare it with each word in the loops 

        string longest = "";
        string word = "";

        foreach (var c in s)
        {
            if (c != ' ')
            {
                word += 'c';
            }
            else
            {
                word = "";
                continue;
            }

            if (longest.Length < word.Length)
            {
                longest = word;
            }
        }

        return longest.Length;
    }
}
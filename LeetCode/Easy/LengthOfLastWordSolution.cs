namespace LeetCode.Easy;

public class LengthOfLastWordSolution
{
    public static int LengthOfLastWord(string s) {
        // Try using a for loop (initial thought was nested loops)
        // Create a string var outside the for loops to store the maximum length
        // then compare it with each word in the loops 

        string lastWord = "";
        bool isLastwordIdentifies = false;
        
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] != ' ' && !isLastwordIdentifies)
            {
                lastWord += s[i];
            }
            else
            {
                if (lastWord.Length != 0)
                {
                    isLastwordIdentifies = true;
                    break;
                }
            }
        }

        return lastWord.Length;
    }
}
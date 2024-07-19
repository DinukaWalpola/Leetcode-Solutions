namespace LeetCode.Easy;

public class SplitStringInABalanceStringSolution
{
    public static int BalancedStringSplit(string s)
    {
        int pairCount = 0;
        int currentCount = 0;
        string pairFirstLetter = "";
        bool isMatching = false;

        for (int i = 0; i < s.Length; i++)
        {
            if (!pairFirstLetter.Equals(""))
            {
                Console.WriteLine($"{i}, pairFirstLetter: {pairFirstLetter}, s[i].ToString(): {s[i].ToString()}");
                
                // Console.WriteLine($"{i}, pairFirstLetter: {pairFirstLetter} ({(int)pairFirstLetter[0]}), s[i].ToString(): {s[i].ToString()} ({(int)s[i]})");

                if (pairFirstLetter.Equals(s[i].ToString()))
                {
                    currentCount++;
                }
                else
                {
                    for (int j = i; j < i + currentCount; j++)
                    {
                        if (!pairFirstLetter.Equals(s[j].ToString()))
                        {
                            isMatching = true;
                        }
                        else
                        {
                            isMatching = false;
                            break;
                        }
                    }
                    
                    if (isMatching)
                    {
                        pairCount++;
                    }
                    
                    isMatching = false;
                    currentCount = 0;
                    pairFirstLetter = "";
                }
            }
            else
            {
                pairFirstLetter = s[i].ToString();
                currentCount++;
            }
        }
        
        return pairCount;
    }
}
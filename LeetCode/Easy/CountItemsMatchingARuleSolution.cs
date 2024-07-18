namespace LeetCode.Easy;

public class CountItemsMatchingARuleSolution
{
    public static int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
    {
        int count = 0;
        int index;

        if (ruleKey.Equals("type"))
        {
            index = 0;
        }
        else if (ruleKey.Equals("color"))
        {
            index = 1;
        }
        else
        {
            index = 2;
        }

        foreach (var item in items)
        {
            if (item[index].Equals(ruleValue))
            {
                count++;
            }
        }

        return count;
    }
}
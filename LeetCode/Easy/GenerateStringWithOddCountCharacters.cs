using System.Text;

namespace LeetCode.Easy;

public class GenerateStringWithOddCountCharacters
{
    public static string GenerateTheString(int n) {
        return n % 2 == 1 ? String.Concat(Enumerable.Repeat("a", n)) : String.Concat(Enumerable.Repeat("a", n - 1)) + "b";
    }
}
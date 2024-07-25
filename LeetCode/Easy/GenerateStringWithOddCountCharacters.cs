using System.Text;

namespace LeetCode.Easy;

public class GenerateStringWithOddCountCharacters
{
    public static string GenerateTheString(int n) {
        StringBuilder word = new StringBuilder();
        
        for(int i = 0; i < n - 1; i++) {
            word.Append("a");
        }
        
        if(n % 2 == 1) {
            word.Append("a");
        }else {
            word.Append("b");
        }
        
        return word.ToString();
    }
}
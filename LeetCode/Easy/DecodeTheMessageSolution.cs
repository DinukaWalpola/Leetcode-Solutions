using System.Text;

namespace LeetCode.Easy;

public class DecodeTheMessageSolution
{ 
    public static string DecodeMessage(string key, string message)
    {
        List<char> filteredKey = key.ToCharArray().Distinct().ToList();
        filteredKey.Remove(' ');
        char[] alphabet = Enumerable.Range('a', 26).Select(n => (char)n).ToArray();
        StringBuilder decodedMessage = new StringBuilder(message.Length);

        foreach (var m in message)
        {
            if (m == ' ')
            {
                decodedMessage.Append(m);
                continue;
            }
            
            int indexOfFilteredKey = filteredKey.IndexOf(m);
            decodedMessage.Append(alphabet[indexOfFilteredKey]);
        }

        return decodedMessage.ToString();
    }
}
namespace LeetCode.Easy;

public class KeyboardRowSolution
{
    public static string[] FindWords(string[] words)
    {
        Dictionary<string, string> keyboardRows = new Dictionary<string, string>
        {
            ["rowOneLower"] = "qwertyuiop",
            ["rowOneUpper"] = "qwertyuiop".ToUpper(),
            ["rowTwoLower"] = "asdfghjkl",
            ["rowTwoUpper"] = "asdfghjkl".ToUpper(),
            ["rowThreeLower"] = "zxcvbnm",
            ["rowThreeUpper"] = "zxcvbnm".ToUpper(),
        };
        bool isContatain;
        List<string> sameKeyboardRowWords = new List<string>();
        (string,string) currentRow = ("", "");

        for (int i = 0; i < words.Length; i++)
        {
            isContatain = true;

            if (keyboardRows["rowOneLower"].Contains(words[i][0]) || keyboardRows["rowOneUpper"].Contains(words[i][0]))
            {
                currentRow = ("rowOneLower", "rowOneUpper");
            }
            else if (keyboardRows["rowTwoLower"].Contains(words[i][0]) ||
                     keyboardRows["rowTwoUpper"].Contains(words[i][0]))
            {
                currentRow = ("rowTwoLower", "rowTwoUpper");
            }
            else if (keyboardRows["rowThreeLower"].Contains(words[i][0]) ||
                     keyboardRows["rowThreeUpper"].Contains(words[i][0]))
            {
                currentRow = ("rowThreeLower", "rowThreeUpper");
            }
            
            for (int j = 1; j < words[i].Length; j++)
            {
                if (!keyboardRows[currentRow.Item1].Contains(words[i][j]) && !keyboardRows[currentRow.Item2].Contains(words[i][j]))
                {
                    isContatain = false;
                    break;
                }
            }

            if (isContatain)
            {
                sameKeyboardRowWords.Add(words[i]);
            }
        }

        return sameKeyboardRowWords.ToArray();
    }
}
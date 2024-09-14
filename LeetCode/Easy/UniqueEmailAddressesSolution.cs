using System.Text;

namespace LeetCode.Easy;

public class UniqueEmailAddressesSolution
{
    public static int NumUniqueEmails(string[] emails)
    {
        List<string> duplicateEmails = new List<string>();
        StringBuilder localName = new StringBuilder();
        int uniqueEmailCount = 0;

        for (int i = 0; i < emails.Length; i++)
        {
            string[] splittedEmail = emails[i].Split("@");

            for (int j = 0; j < splittedEmail[0].Length; j++)
            {
                if (emails[i][j] == '+')
                {
                    break;
                }

                if (emails[i][j] == '.')
                {
                    continue;
                }

                localName.Append(emails[i][j]);
            }

            if (!duplicateEmails.Contains($"{localName}@{splittedEmail[1]}"))
            {
                uniqueEmailCount++;
            }
            
            duplicateEmails.Add($"{localName}@{splittedEmail[1]}");
            localName.Clear();
        }

        return uniqueEmailCount;
    }
}
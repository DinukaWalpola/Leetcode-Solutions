namespace LeetCode.Easy;

public class NumberOfSeniorCitizensSolution
{
    public static int CountSeniors(string[] details)
    {
        int count = 0;

        for (int i = 0; i < details.Length; i++)
        {
            int age = int.Parse($"{details[i][11]}{details[i][12]}");

            if (age > 60)
            {
                count++;
            }
        }

        return count;
    }
}
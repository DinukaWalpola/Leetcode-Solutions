namespace LeetCode.Easy;

public class DestinationCitySolution
{
    public static string DestCity(IList<IList<string>> paths)
    {
        HashSet<string> startingCity = new HashSet<string>();
        List<string> endingCity = new List<string>();
        string finalDestination = "";

        for (int i = 0; i < paths.Count; i++)
        {
            startingCity.Add(paths[i][0]);
            endingCity.Add(paths[i][1]);
        }

        for (int i = 0; i < endingCity.Count; i++)
        {
            if (!startingCity.Contains(endingCity[i]))
            {
                finalDestination = endingCity[i];
            }
        }

        return finalDestination;
    }
}
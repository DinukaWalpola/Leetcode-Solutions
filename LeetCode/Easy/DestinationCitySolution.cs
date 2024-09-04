namespace LeetCode.Easy;

public class DestinationCitySolution
{
    public static string DestCity(IList<IList<string>> paths)
    {
        HashSet<string> startingCity = new HashSet<string>();
        string finalDestination = "";

        for (int i = 0; i < paths.Count; i++)
        {
            startingCity.Add(paths[i][0]);
        }

        for (int i = 0; i < paths.Count; i++)
        {
            if (!startingCity.Contains(paths[i][1]))
            {
                finalDestination = paths[i][1];
            }
            else 
            {
                startingCity.Remove(paths[i][1]);
            }
        }

        return finalDestination;
    }
}
namespace LeetCode.Easy;

public class RingsAndRodsSolution
{
    public static int CountPoints(string rings)
    {
        List<char>[] rods =
        {
            new List<char>(), 
            new List<char>(),
            new List<char>(),
            new List<char>(),
            new List<char>(),
            new List<char>(),
            new List<char>(),
            new List<char>(),
            new List<char>(),
            new List<char>(),
        };
        int pointCount = 0;

        for (int i = 1; i < rings.Length; i += 2)
        {
            rods[int.Parse(rings[i].ToString())].Add(rings[i - 1]);
        }

        for (int i = 0; i < rods.Length; i++)
        {
            if (rods[i].Distinct().Count() == 3)
            {
                pointCount++;
            }
        }

        return pointCount;
    }
}
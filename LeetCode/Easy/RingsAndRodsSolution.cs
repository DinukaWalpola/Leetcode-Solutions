namespace LeetCode.Easy;

public class RingsAndRodsSolution
{
    public static int CountPoints(string rings)
    {
        List<char>[] rods = new List<char>[10];
        int pointCount = 0;

        for (int i = 0; i < rods.Length; i++)
        {
            rods[i] = new List<char>();
        }

        for (int i = 1; i < rings.Length; i += 2)
        {
            rods[int.Parse(rings[i].ToString())].Add(rings[i - 1]);
        }

        for (int i = 0; i < rods.Length; i++)
        {
            if (rods[i].Contains('R') && rods[i].Contains('G') && rods[i].Contains('B'))
            {
                pointCount++;
            }
        }

        return pointCount;
    }
}
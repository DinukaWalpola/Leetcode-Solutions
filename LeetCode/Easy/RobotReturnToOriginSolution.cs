namespace LeetCode.Easy;

public class RobotReturnToOriginSolution
{
    public static bool JudgeCircle(string moves)
    {
        int x = 0;
        int y = 0;

        foreach (var m in moves)
        {
            switch (m)
            {
                case 'R':
                    x++;
                    break;
                case 'L':
                    x--;
                    break;
                case 'U':
                    y++;
                    break;
                case 'D':
                    y--;
                    break;
            }
        }

        if (x == 0 && y == 0) return true;

        return false;
    }
}
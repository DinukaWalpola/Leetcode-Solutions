namespace LeetCode.Easy;

public class SnakeInMatrix
{
    public static int FinalPositionOfSnake(int n, IList<string> commands)
    {
        int[,] grid = new int[n,n];
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                grid[i, j] = count;
                count++;
            }
        }
        
        int index = 0;
        int col = 0;
        int row = 0;

        for (int i = 0; i < commands.Count; i++)
        {
            if (commands[i] == "RIGHT")
            {
                col++;
                index = grid[row, col];
            }
            else if (commands[i] == "LEFT")
            {
                col--;
                index = grid[row, col];
            }
            else if (commands[i] == "DOWN")
            {
                row++;
                index = grid[row, col];
            }
            else
            {
                row--;
                index = grid[row, col];
            }
        }

        return index;
    }
}
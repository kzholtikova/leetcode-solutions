public class Solution {
    public int MatrixScore(int[][] grid) {
        int score = grid.GetLength(0) * (int)Math.Pow(2, grid[0].Length - 1);
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            if (grid[i][0] == 0)
            {
                grid[i] = grid[i].Select(x => (x + 1) % 2).ToArray();
            }
        }

        for (int j = 1; j < grid[0].Length; j++)
        {
            int colSum = Enumerable.Range(0, grid.GetLength(0)).Select(x => grid[x][0] ^ grid[x][j]).Sum();
            if (colSum < grid.GetLength(0) / 2.0)
            {
                score += (grid.GetLength(0) - colSum) * (int)Math.Pow(2, grid[0].Length - j - 1);
            } else { score += colSum * (int)Math.Pow(2, grid[0].Length - j - 1); }
        }
        
        return score;
    }
}

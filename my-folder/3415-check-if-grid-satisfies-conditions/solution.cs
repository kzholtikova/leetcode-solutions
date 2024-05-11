public class Solution {
    public bool SatisfiesConditions(int[][] grid) {
        for (int i = 0; i <= grid.GetUpperBound(0); i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if ((j != grid[0].Length - 1 && grid[i][j] == grid[i][j + 1]) || (i != grid.GetUpperBound(0) && grid[i][j] != grid[i + 1][j]))
                {
                    return false;
                }
            }
        }

        return true;
    }
}

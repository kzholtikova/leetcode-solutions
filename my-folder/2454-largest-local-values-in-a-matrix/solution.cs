public class Solution {
    public int[][] LargestLocal(int[][] grid) {
        int[][] largestLocals = new int[grid.GetLength(0) - 2][];
        for (int i = 0; i < grid.GetLength(0) - 2; i++)
        {
            largestLocals[i] = new int[grid[0].Length - 2];
            for (int j = 0; j < grid[0].Length - 2; j++)
            {
                largestLocals[i][j] = Enumerable.Range(i, 3).Select(x => grid[x][j..(j + 3)].Max()).Max();
            }
        }
        
        return largestLocals;
    }
}

public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        if (cost.Length == 0) { return 0; }
        
        int[] minCosts = new int[cost.Length + 2];
        minCosts[0] = 0; minCosts[1] = 0; minCosts[2] = 0;
        
        for (int i = 3; i < cost.Length + 2; i++)
        {
            int min2 = minCosts[i - 2] + cost[i - 3];
            int min1 = minCosts[i - 1] + cost[i - 2];
            minCosts[i] += Math.Min(min2, min1);
        }
        
        return minCosts[^1];
    }
}

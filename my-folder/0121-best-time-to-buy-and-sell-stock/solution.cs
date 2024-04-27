public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int[] maxCosts = new int[prices.Length];
        maxCosts[^1] = prices[^1];

        for (int i = prices.Length - 2; i >= 0; i--)
        {
            maxCosts[i] = Math.Max(maxCosts[i + 1], prices[i]);
        }
        
        for (int i = 0; i < prices.Length - 1; i++)
        {
            int curProfit = maxCosts[i] - prices[i];
            maxProfit = curProfit > maxProfit ? curProfit : maxProfit;
        }

        return maxProfit;
    }
}

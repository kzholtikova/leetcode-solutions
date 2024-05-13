public class Solution {
    public long MaximumHappinessSum(int[] happiness, int k) {
        Array.Sort(happiness);
        long maxHappiness = 0;
        for (int i = 0; i < k; i++)
        {
            maxHappiness += (happiness[^(i + 1)] - i) > 0 ? happiness[^(i + 1)] - i : 0;
        }

        return maxHappiness;
    }
}

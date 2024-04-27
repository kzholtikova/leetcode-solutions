public class Solution {
    public int[] CountBits(int n) {
        int[] bitsCounts = new int[n + 1]; bitsCounts[0] = 0;
        if (n > 0) { bitsCounts[1] = 1; }
        
        for (int i = 2; i <= n; i++)
        {
            bitsCounts[i] = i % 2 == 0? bitsCounts[i / 2] : bitsCounts[i - 1] + 1;
        }
        
        return bitsCounts;
    }
}

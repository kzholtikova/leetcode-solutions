public class Solution {
    public int FindMaxK(int[] nums) {
        int max = -1;
        foreach (int n in nums)
        {
            if (n > max && nums.Contains(-n))
            {
                max = n;
            }
        }

        return max;
    }
}

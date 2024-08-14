public class Solution {
    public int SmallestDistancePair(int[] nums, int k) {
        Array.Sort(nums);
        int low = 0, high = nums[nums.Length - 1] - nums[0];
        while (low < high)  // binary search
        {
            int mid = (low + high) / 2;
            int count = CountPairsWithMaxDistance(nums, mid);
            if (count < k)
                low = mid + 1;
            else
                high = mid;
        }

        return low;
    }

    public static int CountPairsWithMaxDistance(int[] nums, int max) {
        int count = 0, left = 0;
        for (int right = 0; right < nums.Length; right++)  // sliding window
        {
            while (nums[right] - nums[left] > max)
                left++;
            count += right - left;
        }
        
        return count;
    }
}

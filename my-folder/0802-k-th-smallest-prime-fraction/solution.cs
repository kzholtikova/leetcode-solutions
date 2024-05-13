public class Solution {
    public int[] KthSmallestPrimeFraction(int[] arr, int k) {
        int[] kthSmallestFraction = new int[2];
        double left = 0, right = 1, mid;
        while (left <= right)
        {
            mid = (right - left) / 2 + left; 
            int smallerThanMid = 0, j = 1; 
            kthSmallestFraction = [0, -1];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                while (j < arr.Length && arr[i] / (double)arr[j] >= mid)
                {
                    j++;
                }

                smallerThanMid += (arr.Length - j);
                if (j < arr.Length && arr[i] / (double)arr[j] > kthSmallestFraction[0] / (double)kthSmallestFraction[1])
                {
                    kthSmallestFraction = [arr[i], arr[j]];
                }
            }
            
            if (smallerThanMid < k) { left = mid; }
            else if (smallerThanMid > k) { right = mid; }
            else { break; }
        }

        return kthSmallestFraction;
    }
}

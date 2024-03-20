public class Solution {
    public int MaxArea(int[] height) {
        int maxArea = 0;
        int leftPointer = 0;
        int rightPointer = height.Length - 1;

        while (leftPointer != rightPointer){
            int minHeightIndex = height[leftPointer] < height[rightPointer] ? leftPointer : rightPointer;
            maxArea = Math.Max(height[minHeightIndex] * (rightPointer - leftPointer), maxArea);

            if(minHeightIndex == leftPointer){
                leftPointer++;
            } else { rightPointer--; }
        }

        return maxArea;
    }
}

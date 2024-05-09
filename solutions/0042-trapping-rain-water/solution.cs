public class Solution {
    public int Trap(int[] height) 
    {
        int[] maxLeft = new int[height.Length], maxRight = new int[height.Length];
        maxLeft[0] = height[0]; maxRight[^1] = height[^1];
        
        for (int i = 1; i < height.Length; i++)
        {
            maxLeft[i] = Math.Max(maxLeft[i - 1], height[i]);
            maxRight[^(i + 1)] = Math.Max(maxRight[^i], height[^(i + 1)]);
           
        }
        
        int result = 0;
        for (int i = 1; i < height.Length - 1; i++)
        {
            int waterUnits = Math.Min(maxLeft[i], maxRight[i]) - height[i];
            result += waterUnits > 0 ? waterUnits : 0;
        }
        
        return result;
    }
}

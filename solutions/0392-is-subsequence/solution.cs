public class Solution {
    public bool IsSubsequence(string s, string t) {
        int[] charsPosition = new int[s.Length + 1]; charsPosition[0] = -1;
        
        for (int i = 1; i <= s.Length; i++)
        {
            for (int j = 1; j <= t.Length; j++)
            {
                if (charsPosition[i - 1] == 0) { return false; }
                
                if (j > charsPosition[i - 1] && s[i - 1] == t[j - 1])
                {
                    charsPosition[i] = j;
                    break;
                }
            }
        }

        return charsPosition[^1] != 0;
    }
}

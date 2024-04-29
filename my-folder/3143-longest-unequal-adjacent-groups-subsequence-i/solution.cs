public class Solution {
    public IList<string> GetLongestSubsequence(string[] words, int[] groups) {
        List<string> subsequence = new();
        int currentNum = -1;

        for (int i = 0; i < words.Length; i++)
        {
            if (groups[i] != currentNum)
            {
                subsequence.Add(words[i]);
                currentNum = groups[i];
            }
        }

        return subsequence;
    }
}

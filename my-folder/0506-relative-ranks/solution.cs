public class Solution {
    public string[] FindRelativeRanks(int[] score) {
        Dictionary<int, int> sortedRanks = score.OrderByDescending(x => x).Select((val, i) => new { val, rank = i + 1 }).ToDictionary(x => x.val, x => x.rank);
        string[] ranks = new string[score.Length];
        for (int i = 0; i < score.Length; i++)
        {
            if (sortedRanks[score[i]] == 1) { ranks[i] = "Gold Medal"; }
            else if (sortedRanks[score[i]] == 2) { ranks[i] = "Silver Medal"; }
            else if (sortedRanks[score[i]] == 3) { ranks[i] = "Bronze Medal"; } 
            else { ranks[i] = $"{sortedRanks[score[i]]}"; }
        }

        return ranks;
    }
}

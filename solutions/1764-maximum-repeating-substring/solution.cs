public class Solution {
    public int MaxRepeating(string sequence, string word) {
        int maxRepeats = 0;
        List<int> ocurrences = new();
        int ocurrenceIndex = sequence.IndexOf(word, 0, StringComparison.Ordinal);

        while (ocurrenceIndex != -1)
        {
            ocurrences.Add(ocurrenceIndex);
            ocurrenceIndex = sequence.IndexOf(word, ocurrenceIndex + 1, StringComparison.Ordinal);
        }

        foreach (int i in ocurrences)
        {
            int currentRepeats = 1;
            int lastOcurrenceIndex = i;

            while (ocurrences.Contains(lastOcurrenceIndex + word.Length))
            {
                lastOcurrenceIndex += word.Length;
                currentRepeats++;
            }
            
            maxRepeats = Math.Max(currentRepeats, maxRepeats);
        }

        return maxRepeats;
    }
}

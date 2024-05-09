public class Solution {
    public string ReversePrefix(string word, char ch) {
        int charIndex = word.IndexOf(ch);
        if (charIndex == -1) { return word; }

        return String.Join("", word[0..(charIndex + 1)].Reverse()) + word[(charIndex + 1)..];
    }
}

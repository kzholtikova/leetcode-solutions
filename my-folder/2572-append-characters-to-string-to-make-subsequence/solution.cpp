class Solution {
public:
    int appendCharacters(string s, string t) {
        int prefixLength = 0;
        for (int i = 0; i < s.length(); i++) {
            if (s[i] == t[prefixLength]) 
                prefixLength++;
        }

        return t.length() - prefixLength;
    }
};

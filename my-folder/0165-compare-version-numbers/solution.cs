public class Solution {
    public int CompareVersion(string version1, string version2) {
        int length = Math.Max(version1.Length, version2.Length);
        int[] v1 = version1.Split('.').Select(x => Int32.Parse(x)).ToArray();
        int[] v2 = version2.Split('.').Select(x => Int32.Parse(x)).ToArray();

        for (int i = 0; i < length; i++)
        {
            int v1Char = i >= v1.Length ? 0 : v1[i];
            int v2Char = i >= v2.Length ? 0 : v2[i];
            
            if (v1Char > v2Char) { return 1; }
            if (v1Char < v2Char) { return -1; }
        }
        
        return 0;
    }
}

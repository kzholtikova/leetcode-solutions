public class Solution {
    public int CountSeniors(string[] details) {
        return details.Count(x => Int32.Parse(x[11..13]) > 60);
    }
}

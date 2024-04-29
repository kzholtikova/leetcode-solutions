public class Solution {
    public int Tribonacci(int n) {
        if (n < 2) { return n; }

        int tribonacci0 = 0, tribonacci1 = 0, tribonacci2 = 1, tribonacci3 = 1;

        for (int i = 3; i <= n; i++)
        {
            tribonacci0 = tribonacci1; tribonacci1 = tribonacci2; tribonacci2 = tribonacci3;
            tribonacci3 = tribonacci0 + tribonacci1 + tribonacci2;
        }

        return tribonacci3;
    }
}

public class Solution {
    public int Fib(int n) {
        int[] fibSequence = new int[n + 1];
        fibSequence[0] = 0;
        if (n > 0) { fibSequence[1] = 1; }

        for (int i = 2; i <= n; i++)
        {
            fibSequence[i] = fibSequence[i - 1] + fibSequence[i - 2];
        }
        
        return fibSequence[n];
    }
}

public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> pascalTringle = new List<IList<int>>();
        pascalTringle.Add(new []{ 1 });
        
        for (int i = 1; i < numRows; i++)
        {
            int[] curRow = new int[i + 1];
            curRow[0] = 1; curRow[i] = 1;

            for (int j = 1; j < i; j++)
            {
                curRow[j] = pascalTringle[i - 1][j - 1] + pascalTringle[i - 1][j];
            }
            
            pascalTringle.Add(curRow);
        }

        return pascalTringle;
    }
}

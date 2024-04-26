public class Solution {
    public IList<int> GetRow(int rowIndex) {
        IList<int> prevRow = new List<int>(), curRow = new List<int>();
        prevRow.Add(1); curRow.Add(1);
        
        for (int i = 1; i <= rowIndex; i++)
        {
            curRow.Insert(0, 1); 

            for (int j = 1; j < i; j++)
            {
                curRow[j] = prevRow[j - 1] + prevRow[j];
            }

            prevRow = new List<int>(curRow);
        }

        return curRow;
    }
}

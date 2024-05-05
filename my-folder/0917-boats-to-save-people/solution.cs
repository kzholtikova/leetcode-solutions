public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        int boatsNum = 0;
        Array.Sort(people);
        
        int i = 0, j = people.Length - 1;
        while (i <= j)
        {
            if (people[j] + people[i] <= limit)
            {
                i++;
            }
            boatsNum++; j--;
        }

        return boatsNum;
    }
}


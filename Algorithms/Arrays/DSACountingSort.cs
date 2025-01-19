namespace Algorithms.Data_Structures;

public class DSACountingSort
{
    //Sorts the array by counting the amount of times a value appears
    //Only works for non-negative numbers, as we place the value at certain index
    
    /* How it works:
     * Step 1 - Create a new array for counting how many times the values appear
     * Step 2 - Iterate through first array
     * Step 3 - For each value, increase count of matching value or add to new place
     */
    public static void CountingSort()
    {
        int[] allNums = new[] { 5, 6, 2, 5, 8, 5, 2, 5, 6, 5, 8, 3 };
        int[] countNums = new int[allNums.Length];
        int[] sorted = new int[allNums.Length];
        
        foreach (var  num in allNums)
        {
            //We'll iterate the first array and count each entry in the position of the new array. 
            //i.e. allNums[3] = 5 will translate to countNums[4] = 1. 
            countNums[num]++;
        }
        
        Console.WriteLine(String.Join(", ", allNums));
        Console.WriteLine(String.Join(", ", countNums));

        int index = 0;
        for (int i = 0; i < countNums.Length; i++)
        {
            while (countNums[i] > 0)
            {
                //sorted[index++] = i;
                //We'll add each index in countNums to the original array allNums, as that represent the values. 
                allNums[index++] = i;
                countNums[i]--;
            }
                
        }
        
        Console.WriteLine(String.Join(", ", allNums));
    }
}
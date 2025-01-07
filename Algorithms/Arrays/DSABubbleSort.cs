namespace Algorithms.Data_Structures;

public class DSABubbleSort
{

    public static void BubbleSort()
    {
        /*
         * Algorithm should loop through each value
         * Compare current value to next in list
         * if current is larger than next, switch index
         * Repeat until next in list is larger
         */
        int[] allNums = new [] { 3, 2, 9, 7, 5, 4, 7, 6};
        for (int i = 0; i < allNums.Length -1; i++)
        {
            for (int j = 0; j < allNums.Length - i - 1; j++)
            {
                if (allNums[j] > allNums[j + 1])
                {
                    int temp = allNums[j];
                    allNums[j] = allNums[j + 1];
                    allNums[j + 1] = temp;
                }
            }
        }
        Console.WriteLine(string.Join(", ", allNums));
        
        /*
         * At first, we'll make an outer loop (keeps track of the original placement
         * Secondly, we'll make an inner loop, which will compare the current position
         * against the next position, and then switch those values. This is also going to be
         * looped through
         */
    }
}
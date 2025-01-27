namespace Algorithms.Data_Structures;

public class DSAMergeSort
{
    /*
     * Merge Sort works by first breaking the array up into smaller subarrays, and building it back together
     * in the sorted order
     */
    
    public static int[] MergeSort(int[] allNums)
    {
        /*
         * Step 1 - Divide the original array into two subarrays, half the size
         * Step 2 - Continuesly divide the subarrays as long as the current piece of array has more than one element
         * Step 3 - Merge two subarrays together and place lowest value first
         * Step 4 - Keep merging until no more subarrays
         */
        
        //int[] allNums = new[] { 5, 4, 2, 11, 9, 12, 6 };
        int half = Convert.ToInt32(Math.Floor((double)allNums.Length / 2));
        int[] left = new int[half];
        int[] right = new int[allNums.Length - half];

        int[] sortedLeft = MergeSort(left);
        int[] sortedRight = MergeSort(right);
        Console.WriteLine(String.Join(", ", sortedLeft));

        return Merge(sortedLeft, sortedRight);
    }

    public static int[] Merge(int[] leftSort, int[] rightSort)
    {
        int[] result = new int[leftSort.Length + rightSort.Length];
        int i = 0;
        int j = 0;
        while (i < leftSort.Length && j < rightSort.Length)
        {
            if (leftSort[i] < rightSort[j])
            {
                result.Append(leftSort[i]);
                i += 1;
            }
            else
            {
                result.Append(rightSort[j]);
                j += 1;
            }

            while (i < leftSort.Length)
            {
                result[j++] = leftSort[i++];
            }

            while (j < rightSort.Length)
            {
                result[i++] = rightSort[j++];
            }

        }
        Console.WriteLine("Final sorted result: /n" + String.Join(", ", result));
        
        return result;
    }
}
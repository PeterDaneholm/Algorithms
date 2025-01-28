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
        
        if (allNums.Length <= 1)
        {
            //Ensuring it's not an infinite recursive loop by returning once equal to or less than 1
            return allNums;
        }
        
        int half = Convert.ToInt32(Math.Floor((double)allNums.Length / 2));
        int[] left = new int[half];
        Array.Copy(allNums, left, half);
        int[] right = new int[allNums.Length - half];
        Array.Copy(allNums, half, right, 0, allNums.Length-half);

        int[] sortedLeft = MergeSort(left);
        int[] sortedRight = MergeSort(right);
        Console.WriteLine(String.Join(", ", sortedLeft));
        Console.WriteLine(String.Join(", ", sortedRight));

        return Merge(sortedLeft, sortedRight);
    }

    public static int[] Merge(int[] leftSort, int[] rightSort)
    {
        int[] result = new int[leftSort.Length + rightSort.Length];
        int i = 0; //index for leftSort
        int j = 0; //index for rightSort
        int k = 0; //index for placing items in result
        
        //Check the position of i and j against the lengths of the arrays
        while (i < leftSort.Length && j < rightSort.Length)
        {
            //Check if the value of the current index in leftSort is less than the value of the current index in rightSort
            if (leftSort[i] < rightSort[j])
            {
                //Place the value of leftSort (lowest) in the index of result
                result[k++] = leftSort[i++];
            }
            else
            {
                //Otherwise place the value of rightSort (lowest) in the index of result
                result[k++] = rightSort[j++];
            }
        }

        //Any values leftover in leftSort will be placed at k index in result
        while (i < leftSort.Length)
        {
            result[k++] = leftSort[i++];
        }
        //Same with any leftover of rightSort
        while (j < rightSort.Length)
        {
            result[k++] = rightSort[j++];
        }

        Console.WriteLine("Final sorted result: /n" + String.Join(", ", result));
        
        return result;
    }
}
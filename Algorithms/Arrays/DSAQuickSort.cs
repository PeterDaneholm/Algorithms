namespace Algorithms.Data_Structures;

public class DSAQuickSort
{
    static int Partition(int[] nums, int low, int high)
    {
        int newPivot = nums[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (nums[j] <= newPivot)
            {
                i += 1;
                (nums[i], nums[j]) = (nums[j], nums[i]);
                Console.WriteLine(i);
                Console.WriteLine(nums[i]);
            }
        }

        //Below we'll swap the pivot element, so that it's placed in the correct place,
        //which will be after all the elements that are lower than it
        (nums[i + 1], nums[high]) = (nums[high], nums[i + 1]);
        return i + 1;
    }
    
    public static void QuickSort(int[] array, int low, int high)
    {
        Console.WriteLine(String.Join(", ", array));

        if (low < high)
        {
            //First we'll do the primary sorting (lower or higher), and get the index of the pivot.
            //Then we'll sort the below sub-array and the above sub-array with the Partition function
            int pivot_index = Partition(array, low, high);
            QuickSort(array, low, pivot_index-1);
            QuickSort(array, pivot_index+1, high);
        }
    }

    public static void ActivateQuickSort()
    {
        /*
         * One of the quickest sorting algorithms
         * Step 1 - Select a pivot element, which we'll sort the rest of the array by
         * Step 2 - Order values so the ones lower are on the left and the ones higher on the right
         * Step 3 - Swap pivot element with the first element of the higher values, ensuring the pivot lands in the right place
         * Step 4 - Do the same operations recursively on the left and right side of the element
         */
        int[] allNums = new[] { 9, 2, 6, 3, 12, 5, 11 };
        int high = allNums.Length - 1; //This declares our initial pivot element
        QuickSort(allNums, 0, high);
    }
}
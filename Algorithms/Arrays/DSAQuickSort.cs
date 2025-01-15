namespace Algorithms.Data_Structures;

public class DSAQuickSort
{
    void Partition(int[] nums, int low, int high)
    {
        int newPivot = nums[high];
        int i = low - 1;
        
    }
    
    public static void QuickSort()
    {
        /*
         * One of the quickest sorting algorithms
         * Step 1 - Select a pivot element, which we'll sort the rest of the array by
         * Step 2 - Order values so the ones lower are on the left and the ones higher on the right
         * Step 3 - Swap pivot element with the first element of the higher values, ensuring the pivot lands in the right place
         * Step 4 - Do the same operations recursively on the left and right side of the element
         */
        int[] allNums = new[] { 9, 2, 6, 3, 12, 5, 11 };
        int pivot = allNums[-1];
        
        for (int i = 0; i < allNums.Length; i++)
        {
            
        }
    }
}
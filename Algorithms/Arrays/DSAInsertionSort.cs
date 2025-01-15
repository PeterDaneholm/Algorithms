namespace Algorithms.Data_Structures;

public class DSAInsertionSort
{
    /*
     * Insertion sort sorts the array by dividing the first half into sorted values, while the second half
     * holds all the unsorted values. Takes one value and puts them into the right place at a time
     */
    public static void InsertionSort()
    {
        /*
         * Step 1 - Get first value from unsorted part of array,
         * Step 2 - Move the value into the correct place in the sorted array
         * Step 3 - Keep going through the unsorted array until all values are iterated
         */
        int[] allNums = new[] { 5, 6, 17, 12, 14, 8, 9, 1, 5, 13 };
        for (int i = 1; i < allNums.Length; i++)
        {
            int current = allNums[i];

            for (int j = 0; j < i - 1; j++)
            {
                if (allNums[j] > current)
                {
                    allNums[j + 1] = allNums[j];
                    allNums[j] = current;
                }
            }

            Console.WriteLine(String.Join(", ", allNums));
        }
    }

    public static void InsertionSort2()
    {
        //From Copilot
        int[] allNums = new[] { 5, 6, 17, 12, 14, 8, 9, 1, 5, 13 };
        for (int i = 1; i < allNums.Length; i++)
        {
            int current = allNums[i];
            int j = i - 1;

            // Shift elements of the sorted part to the right
            while (j >= 0 && allNums[j] > current)
            {
                allNums[j + 1] = allNums[j];
                j--;
            }

            // Place the current element in its correct position
            allNums[j + 1] = current;

            Console.WriteLine(String.Join(", ", allNums));
        }
    }
}
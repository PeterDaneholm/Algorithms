namespace Algorithms.Data_Structures;

public class DSASelectionSort
{
    /*
     * Algorithm which sorts the array by moving the lowest index to the rightmost available
     * spot. 
     */

    public static void SelectionSort()
    {
        /*
         * First we'll need to iterate through the list for each entry
         * Second we'll then need to compare this entry with each other entry, i.e. new loop
         * if i entry is lower, pop and place in current spot - or swap the elements
         * 
         */
        int[] allNums = new[] { 5, 4, 2, 11, 9, 12, 6 };
        for (int i = 0; i < allNums.Length; i++)
        {
            int minIndex = i;
            //j should be i + 1, since there's no reason in comparing the same entry
            //to itself. We'll also assign the new lowest index to variable,
            //so we don't switch them all the time = saves complexity
            for (int j = i + 1; j < allNums.Length; j++)
            {
                if (allNums[j] < allNums[minIndex])
                {
                    minIndex = j;
                }
                Console.WriteLine(String.Join(", ", allNums));
            }
            //We'll swap the two elements in the list
            (allNums[i], allNums[minIndex]) = (allNums[minIndex], allNums[i]);
        }
        Console.WriteLine(String.Join(", ", allNums));
    }
    
    /*
     * Time complexity for SelectionSort is: n/2 * n, or in O(n^2). This is because the algorithm has to loop through
     * the array n times to sort all, and then an additional time for each entry. Therefore an exponential increase with n size.  
     */
}
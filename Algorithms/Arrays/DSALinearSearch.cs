namespace Algorithms.Data_Structures;

public class DSALinearSearch
{
    /*
     * Searches through an array and returns the index of the matching value
     */
    
    public static int LinearSearch(int[] allNums, int target)
    {
        for (int i = 0; i < allNums.Length; i++)
        {
            if (allNums[i] == target)
            {
                Console.WriteLine($"Match found at index {i}");
                return i;
            }
        }
        Console.WriteLine($"Match not found, you get a -1");
        return -1;
    }
}
namespace Algorithms.Data_Structures;

public class Arrays
{
    /*
     * Can declare arrays in multiple ways:
     *      - int[] allNums = new int[3] {1, 2, 3};
     *      - int[] allNums = {1, 2, 3}; 
     */
    public static void FindLowest()
    {
        int[] allNums = {4, 6, 12, 19, 3, 8, 6};
        int lowest = allNums[0];

        foreach (var i in allNums)
        {
            if (i < lowest)
            {
                lowest = i;
            }
            Console.WriteLine(lowest);
        }
    }
}
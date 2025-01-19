namespace Algorithms.Data_Structures;

public class DSARadixSort
{
    /*
     * Radix Sort sorts an array by individual digits (in each entry?), starting with the least insignificant,
     * which would be rightmost.
     * Only works with non-negative numbers
     *
     * We need to make sure that the values are moved between the two arrays in a stable way. This means, that
     * the initial order of the values should remain the same. 
     */

    public static int[] allNums = new[] { 23, 51, 38, 19, 88, 21, 47, 27};
    
    public static void RadixSort()
    {
        /*
         * Step 1 - Starting with the rightmost digit,
         * Step 2 - Sort by first placing each digit in the correct container (match digit value 0-9),
         * Step 2.5 - Replace values in the correct sorted order
         * Step 3 - Repeat until there are no digits left
         */
        List<List<int>> radixArray = new List<List<int>>(10);
        for (int i = 0; i < 10; i++)
        {
            radixArray.Add(new List<int>());
        }
        for (int i = 0; i < allNums.Length; i++)
        {
            var digits = allNums[i].ToString().Select(digit => int.Parse(digit.ToString())).ToArray();
            Console.WriteLine(String.Join(", ", digits));
            foreach (var digit in digits)
            {
                radixArray[digit].Add(allNums[i]);
            }
        }

        foreach (var list in radixArray)
        {
            Console.WriteLine(String.Join(" ", list));
        }
    }
}
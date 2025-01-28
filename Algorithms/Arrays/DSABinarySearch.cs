using System.Xml.Xsl;

namespace Algorithms.Data_Structures;

public class DSABinarySearch
{
    /*
     * Algorithm that searches through an  *sorted* array and returns the index of the matching value
     * Will not work if the array isn't sorted
     */
    public static int BinarySearch(int[] allNums, int target, int left, int right)
    {
        if (left > right)
        {
            Console.WriteLine($"Index not found :(");
            return -1;
        }

        int mid = left + (right - left) / 2;
        if (allNums[mid] == target)
        {
            Console.WriteLine($"Index found at {mid}");
            return mid;
        }
        else if (allNums[mid] > target)
        {
            return BinarySearch(allNums, target, left, mid - 1);
        }
        else
        {
            return BinarySearch(allNums, target, mid + 1, right);
        }
    }
}
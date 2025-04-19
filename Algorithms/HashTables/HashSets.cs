using System.Globalization;

namespace Algorithms;

public class HashSets
{
    /* Hash Sets
     * A Hash Set is a type of Hash Table that usually holds a larger number of elements
     * Search, add, and removing elements are still very fast though
     *
     * A Hash set cannot have more than 1 element with the same value!
     *
     * We can run into scenarios, where the hash function places all the values in the same bucket, which is definitely not ideal.
     * In worst case scenarios, we can end up with a time complexity of O(n), which is the same as for arrays and linked lists.
     * Therefore it's very important to design the hash function so it will distribute the values into all the buckets.
     * Also remember to utilize all buckets and only have about as many as hash set elements, as having too many is a waste of memory and having too few is a waste of time. 
     */
    
    //Example
    public List<List<String>> buckets = new List<List<string>>();

    private int HashFunc(string value)
    {
        int sum = 0;
        foreach (var c in value)
        {
            sum += c.GetHashCode();
        }

        return sum % buckets.Count;
    }

    public string AddFunc(string value)
    {
        var index = HashFunc(value);
        var bucket = buckets[index];
        foreach (var b in bucket)
        {
            if (b == value) return "Already here";
        }
        buckets[index].Add(value);
        return "All good, added";
    }

    public bool Contains(string value)
    {
        var index = HashFunc(value);
        var bucket = buckets[index];
        foreach (var b in bucket)
        {
            if (b == value) return true;
        }

        return false;
    }
    //Repeat implementation for removing below   
    
    //
}
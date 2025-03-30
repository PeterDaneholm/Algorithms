namespace Algorithms;

public class HashTables
{
    /*
     * Hash tables are designed to be blazing fast(tm) to work with, and searching, adding, or deleting data actions
     * are super fast, even with larger amounts of data. If we wanted to find an item in a hash list, we can use a
     * hash function that works differently than how an array or a linked lists would go about the process.
     * Each entry in a Hash Table is called a 'bucket'.

     * We can demonstrate a Hash Table in the below 5 steps:
     * Step 1 - Creating an array
     * Step 2 - Adding values to the buckets with a hash function
     * Step 3 - Looking up an element with a hash function
     * Step 4 - Handling collisions
     * Step 5 - Basic Hash Set code example
     */
    //Step 1
    public static int[] allNums = new int[]{5, 6, 9, 3, 0, 7, 1, 8, 2, 4};
    //If the array is alphabetically stored, we could use binary search to quickly find the match. However, we can instead
    //use a Hash Set, which is a simplified version of a Hash Table, or a regular Hash Table

    public HashSet<int> allNumsHashSet = new HashSet<int>(); //C# standard implementation here
    //Step 2
    //We'll now create the hash function, which should place the values in the right place of the array
    //In the example, this is done by converting the string values into a unicode number (numerical value), and a subsequent
    //modulo operator with 10 is performed on that number. This leaves an index they can be placed in: https://www.w3schools.com/dsa/dsa_theory_hashtables.php
    //Once this is done for all values, the new hashset has the values sorted in the right order
    
    //Step 3 - Looking up names with a hash function
    /*
     * We can now create a hash function to check the incoming value, and using the same algorithm as before, we can get
     * the index straight away.
     * This will be the same procedure if we wanted to delete a value from a hash set
     */
    
    //Step 4 - Handling Collision
    /*
     * 
     */
}
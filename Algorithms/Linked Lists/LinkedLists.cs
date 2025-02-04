namespace Algorithms.Linked_Lists;

public class LinkedLists
{
    /*
     * A linked list contains nodes, which each contains a reference (data, pointer, etc) to the following node.
     * A benefit is that the nodes are stored whereever there's available memory, it doesn't have to be continously
     * after each other, unlike an array.
     * When adding or removing, the remaining nodes do not have to be shifted.
     *
     * Linked Lists vs. Arrays
     * Linked lists are linear data structures we create ourselves, whereas arrays are built-in feature of a language.
     * Does not have a fixed size in memory, unlike arrays
     * Higher memory usage than arrays
     * Nodes (or elements) cannot be accessed directly
     * Unlike arrays, nodes can be inserted or deleted in constant time, and no shifting operations are needed
     */
    
    /*
     * Computer Memory
     * In arrays, all the values are stored sequentially. This way, the program will now to skip ahead to the requested bit,
     * when trying to access a specific index of the array. I'll start at the first bit, and then skip ahead nx2 bits, since
     * integers take up two bits.
     * This also means, that when adding or removing items the other items will have to be shifted forwards or backwards
     * to match the new value's place. Not all languages does this in the background (e.g. C)
     * For a Linked List, the nodes are placed whereever there's empty memory. However, the nodes are also then bigger,
     * as they need 2 bits to store the integer value, and another 2 bits to store the address of the next node
     * First node is called 'Head', and the last 'Tail'.
     * However, because of this structure we cannot access an index directly with myLinkedList[n]. We have to start with
     * the head node, and iterate through until we find the address, and subsequent value, of the desired index. 
     */
}
namespace Algorithms.StacksAndQueues;

public class Stacks
{
    /* Stacks
     * An analogy for a stack could be a pile of pancakes, in terms of how items are stored. Works by the principle
     * LIFO - Last in, First out. In other words, the first item to be removed is the one at the top of the stack
     * Basic operations:
     * 1. Push() - Adds new element
     * 2. Pop() - Removes and Returns the item at the top of the stack
     * 3. Peek() - Returns the top element
     * 4. isEmpty() - Returns false if there are elements in the stack
     * 5. Size() - Checks the size of the stack (number of items)
     *
     * Stacks can be implemented with either arrays or linked lists.
     * Can be particular good for operations such as undo, history, reverting to previous states, backtracking, or
     * implement algorithms for depth-first searches.
     */
    
    /* Stacks with Arrays
     * There are both pros and cons with using arrays:
     * Pros - Memory efficient, easier to implement and understand
     * Cons - Fixed size can mean it can be too large, or not have enough space
     */
    public static int[] newArray = new[] { 5, 6, 12, 18, 7, 9, 15, 13, 0, 12 };

    public static void StackArrayOperations(string operation)
    {
        switch (operation)
        {
            case "pop":
                var toList = newArray.ToList();
                toList.RemoveAt(-1);
                var toArray = toList.ToArray();
                Console.WriteLine(String.Join(", ", toArray));
                break;
            case "push":
                var tempList = newArray.ToList();
                tempList.Append(8); //Or the newly provided item to add at the end of the list
                var tempArray = tempList.ToArray();
                Console.WriteLine(String.Join(", ", tempArray));
                break;
            case "peek":
                int lastIndex = newArray[-1];
                Console.WriteLine($"Peeked at this value: {lastIndex}");
                break;
            case "isEmpty":
                if (newArray.Length == 0)
                {
                    Console.WriteLine("Stack is empty - true");
                }
                else
                {
                    Console.WriteLine("Stack is not empty - false");
                }
                break;
            case "size":
                Console.WriteLine($"Length of stack: {newArray.Length}");
                break;
            default:
                Console.WriteLine("Not a valid operation");
                break;
        }
    }
    /*
     * However, the most ideal would be to create a custom Stack-class, and built in the operations there. 
     */
    
    /* Stacks with Linked Lists
     * A stack implemented with a linked list is much more dynamic, meaning it's much easier to grow scale it depending on need.
     * They do come with a higher memory cost, and can become more complex due to the pointer inclusion. 
     */
}
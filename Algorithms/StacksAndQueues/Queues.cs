namespace Algorithms.StacksAndQueues;

public class Queues
{
    /* Queues
     * An example of a queue can be like standing in line for anything. It works on the principle of FIFO - first in,
     * first out. We have some basic operations for queues:
     * 1. Enqueue - Add a new element to a queue
     * 2. Dequeue - Removes and returns the first (front) element from the queue
     * 3. Peek - Return the first element in the queue
     * 4. isEmpty - check if queue is empty
     * 5. Size - finds the size of the queue
     *
     * Can work well for handling jobs that need to happen in order, or algorithms for a breadth-first search. Can also
     * be implemented using both arrays and linked lists.
     */
    
    /* Using Arrays
     * Pros - More memory efficient, and easier to implement and understand
     * Cons - Fixed size of arrays can be too large or not large enough, cost of shifting each time an element dequeued as
     * all other elements need to be shifted forward, some languages have specific data structures better suited to handle queues
     * than arrays.
     * C# has a built in Queue structure
     */
    
    /* Using linked lists
     * A queue can also be made with a linked list.
     * Pros - Dynamic sizing of queue, no shifting cost of dequeueing elements
     * Cons - Higher memory cost, readability can result in higher complexity.  
     */
    
    public static void QueueExample()
    {
        Queue<int> exampleQueue = new Queue<int>();
    }
}
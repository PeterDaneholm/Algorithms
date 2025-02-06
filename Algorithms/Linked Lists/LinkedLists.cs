namespace Algorithms.Linked_Lists;

public class Node
{
    public int value;
    public Node? next;
    public Node? previous;
}
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
     * as they need 2 bits to store the integer value, and another 2 bits to store the address of the next node. Size of bits may vary
     * First node is called 'Head', and the last 'Tail'.
     * However, because of this structure we cannot access an index directly with myLinkedList[n]. We have to start with
     * the head node, and iterate through until we find the address, and subsequent value, of the desired index.
     *
     * Types of Linked Lists
     * Linked lists can be in one of 3 basic forms:
     * Singly, Doubly, or Circular
     * Single is the most simple, as each node only links to the next
     * Doubly has both reference to the previous and to the next node, and therefore takes up more memory
     * Circular can be both a singly or a doubly, but it also references the head node from the tail node, as they normally don't. A doubly
     * will also reference the tail node from the head node.
     *
     * When assigning values to the next/previous, we can simply include more info.
     *
     * Linked List Operations
     * 1. Traversal
     * Traversal means going through the list node by node, can be done either forwards or backwards
     * 2. Remove a Node
     * Whenever we want to delete it a node, we'll first have to re-link the previous and next node to keep the linked list going.
     * Always a good idea to connect the 'next' value the next node, to avoid a dangling pointer. 
     * 3. Add a node
     * Very similar to removing a node, we'll first traverse through to find the place we want to add the new node, and
     * then assign the previous node's next to the new node, and the next to the following node. 
     * 4. Sort
     * Most sorting algorithms used on arrays also work for linked list, with the exception of algorithms that jump to
     * a specific index at the start, as that action is impossible in a linked list.
     * Otherwise time complexity is generally the same for sorting algorithms on arrays and linked lists. 
     */
    
    //Example af Single linked
    public static Node CreateNode(int val)
    {
        return new Node
        {
            value = val,
        };
    }

    public static void LinkedListExample()
    {
        Node node1 = CreateNode(3);
        Node node2 = CreateNode(6);
        Node node3 = CreateNode(1);
        Node node4 = CreateNode(8);

        node1.next = node2;
        node2.next = node3;
        node3.next = node4;

        Node currentNode = node1;
        while (currentNode != null)
        {
            Console.WriteLine(currentNode.value);
            currentNode = currentNode.next;
        }
    }

    public static void CircularExample()
    {
        Node node1 = CreateNode(3);
        Node node2 = CreateNode(6);
        Node node3 = CreateNode(1);
        Node node4 = CreateNode(8);

        node1.next = node2;
        //The below line makes the list circular
        node1.previous = node4;

        node2.next = node3;
        node2.previous = node1;

        node3.next = node4;
        node3.previous = node2;

        //The below line is part of making it circular
        node4.next = node1;
        node4.previous = node3;
        
        //traversal forward
        Node currentNode = node1;
        Node startNode = node1;
        while (currentNode != startNode)
        {
            Console.WriteLine(currentNode.value);
            currentNode = currentNode.next;
        }
    }
}
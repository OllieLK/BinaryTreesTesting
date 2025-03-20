using System;
using System.Collections.Generic;

namespace Blackboard
{

    // This is an auxiliary Node class that stores an integer value and references to left/right child trees
    public class Node
    {
        // Node's attributes
        public int value;  // stores the value at this node
        public Node left, right; // references to left and right nodes (null represents the empty tree)

        // Constructor to initialise the value of the node
        public Node(int value)
        {
            this.value = value;  // same as self in Python!
            left = null;
            right = null;
        }
    }

    public class BST
    {

        // BST's attributes
        public Node root;  // the root node

        // Constructor, which creates the "empty tree"
        public BST()
        {
            root = null; // initialise root to null
        }

        // Once you've implemented Insert, you can use this constructor to build
        // BSTs from an array of values provided as an argument
        public BST(int[] values)
        {
            foreach (int v in values) Insert(v);  // perform insertion iteratively
        }

        // You can use this to visualise a BST object.
        // DO NOT EDIT THIS.
        public void Display()
        {
            Display(root, 0);
            Console.Write("\n");
        }

        // Auxiliary display method.
        // DO NOT EDIT THIS.
        public void Display(Node node, int spacing)
        {
            if (node == null) return;
            spacing += 10;
            Display(node.right, spacing);
            Console.Write('\n' + new string(' ', spacing - 10));
            Console.Write(node.value);
            Display(node.left, spacing);
        }


        // This is a function that kicks off the recursive Search procedure.
        // DO NOT EDIT THIS. Edit the recursive (auxiliary) method below instead.
        public bool Search(int value)
        {
            return Search(root, value); // returns true if value exists, false otherwise
        }

        // This is where you should implement Search.
        // Use the pseudo-code comments below as a guide!
        private bool Search(Node currentNode, int value)
        {
            // if currentNode is the empty tree, then the value does not exist
            //     return "false"

            // if the currentNode contains value, we've found it!
            //     return "true"
            // else, if the value is less than currentNode's value
            //     recursively search the left tree, return the result
            // else
            //     recursively search the right tree and return the result

            // delete this to test your implementation
            throw new NotImplementedException("Search not yet implemented!");
        }

        // This is a function that kicks off the recursive Insert procedure
        // DO NOT EDIT THIS. Edit the recursive (auxiliary) method below instead
        public void Insert(int value)
        {
           root = Insert(root, value);
        }

        // This is where you should implement Insert.
        // Use the pseudo-code comments below as a guide!
        private Node Insert(Node currentNode, int value)
        {
            // if currentNode is an empty tree
            //     create a new node with the given value, and return it

            // if value < currentNode's value
            //     recursively insert into the left tree, assigning the result to the left tree
            // else, if value > currentNode's value
            //     recursively insert into the right tree, assigning the result to the right tree

            // should the code reach this point, then the value already exists so return currentNode

            throw new NotImplementedException("Insert not yet implemented!");

        }

        // Write all of your testing code here!
        public static void Main(string[] args)  // this is the "entry point" to the program
        {

            // 1. Try to create the three binary search trees here.
            // Here is the first part of tree (a) to get you started.
            BST tree = new BST();
            tree.root = new Node(8);
            // tree1.root.left = new Node(...);
            // tree1.root.right = new Node(...);
            tree.Display();

            // 2. Implement Search, and test that this code works for (a):
            Console.WriteLine(tree.Search(14));  // should be true
            Console.WriteLine(tree.Search(20));  // should be false

            // 3. Implement Insert, and test that this code produces tree (a)
            int[] values = { 8, 5, 12, 1, 9, 17, 14 };
            tree = new BST(values);
            tree.Display();

            // What happens if you sort/reverse the values first?
            // Try uncommenting different combinations of the lines below!
        
            // Array.Sort(values);
            // Array.Reverse(values);

            // tree = new BST(values);
            // tree.Display();


        }

    }
}
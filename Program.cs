using System;
using Rovy_Assignment_7_3_BST;

internal class Program
{
    private static void Main(string[] args)
    {
        // Create the BST helper object
        SearchBST bst = new SearchBST();

        // Start with an empty tree
        TreeNode root = null;

        // Build the BST with some sample values
        root = bst.Insert(root, 8); 
        root = bst.Insert(root, 3);
        root = bst.Insert(root, 1);
        root = bst.Insert(root, 6);
        root = bst.Insert(root, 14);
        root = bst.Insert(root, 4);
        root = bst.Insert(root, 7);
        root = bst.Insert(root, 13);

        Console.WriteLine("In-order traversal of the BST (sorted):");
        SearchBST.InOrderTraversal(root);
        Console.WriteLine(); // new line

        // Ask user for a value to search
        Console.Write("Enter a value to search for: ");
        string input = Console.ReadLine();

        // Convert string input to int (beginner-friendly TryParse)
        if (!int.TryParse(input, out int val))
        {
            Console.WriteLine("Invalid number entered. Exiting.");
            return;
        }

        // Search the BST
        TreeNode found = bst.Search(root, val); 

        if (found != null)
        {
            Console.WriteLine($"Value {val} found in the BST.");
        }
        else
        {
            Console.WriteLine($"Value {val} NOT found in the BST.");
        }

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}
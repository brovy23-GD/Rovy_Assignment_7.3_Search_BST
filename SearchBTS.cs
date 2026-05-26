using System;

namespace Rovy_Assignment_7_3_BST
{
    internal class SearchBST
    {
        public TreeNode Search(TreeNode root, int val)
        {
            // 1. Base case: if the current node is null, the value is not found.
            if (root == null)
            {
                return null;
            }

            // 2. If current node's value matches the search value, return this node.
            if (root.val == val)
            {
                return root;
            }

            // 3. If the value is less than current node's value, search LEFT subtree.
            if (val < root.val)
            {
                return Search(root.left, val);
            }

            // 4. Otherwise (val > root.val), search RIGHT subtree.
            return Search(root.right, val);
        }

        public TreeNode Insert(TreeNode root, int val)
        {
            // 1. If current node is null, create a new node here.
            if (root == null)
            {
                return new TreeNode(val);
            }

            // 2. If val is smaller, insert into LEFT subtree.
            if (val < root.val)
            {
                root.left = Insert(root.left, val);
            }
            // 3. If val is larger, insert into RIGHT subtree.
            else if (val > root.val)
            {
                root.right = Insert(root.right, val);
            }
            // If val == root.val, we do nothing (no duplicates).

            // 4. Return the (possibly unchanged) root of this subtree.
            return root;
        }

        // In‑order traversal: Left - Node - Right (prints values in sorted order)
        public static void InOrderTraversal(TreeNode root)
        {
            // Base case: if we hit a null node, there is nothing to do
            if (root == null)
            {
                return; // stops recursion
            }

            // 1. Visit the entire LEFT subtree first
            InOrderTraversal(root.left);

            // 2. Print the current node value
            Console.WriteLine(root.val + " ");

            // 3. Visit the entire RIGHT subtree
            InOrderTraversal(root.right);
        }
    }
}
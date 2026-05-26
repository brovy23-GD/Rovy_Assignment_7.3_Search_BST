using System;

namespace Rovy_Assignment_7_3_BST
{
    public class TreeNode
    {
        public int val;       // Value stored in this node
        public TreeNode left; // Left child
        public TreeNode right;// Right child

        // Constructor: create a node with a value, and optional left/right children
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
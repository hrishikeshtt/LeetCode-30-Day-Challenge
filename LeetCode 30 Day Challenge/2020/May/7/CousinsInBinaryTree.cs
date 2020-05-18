using System;

namespace LeetCode_30_Day_Challenge
{
    class CousinsInBinaryTree
    {

        static void MainCousinsInBinaryTree(string[] args)
        {
            Console.WriteLine("Hello, world!");
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.right = new TreeNode(4);
            root.right = new TreeNode(3);
            root.right.right = new TreeNode(5);
            bool isCousins = IsCousins(root, 5, 4);
        }
        public static bool IsCousins(TreeNode root, int x, int y)
        {
            var xDepthParent = GetNodeLevel(root, x);
            var yDepthParent = GetNodeLevel(root, y);
            if (xDepthParent.depth == yDepthParent.depth && xDepthParent.parentNode.val != yDepthParent.parentNode.val)
                return true;
            return false;


        }

        public static (TreeNode parentNode, int depth) GetNodeLevel(TreeNode node, int value = 0, int level = 0, TreeNode parentNode = null)
        {
            if (node != null)
            {
                if (node.val == value)
                {
                    return (parentNode: parentNode, depth: level);
                }

                (TreeNode, int) downlevel = GetNodeLevel(node.left, value, level + 1, node);
                if (downlevel.Item2 != 0)
                {
                    return downlevel;
                }

                downlevel = GetNodeLevel(node.right, value, level + 1, node);
                return downlevel;
            }
            return (null, 0);
        }

    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

}

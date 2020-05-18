//using System;
//using System.Collections.Generic;

//namespace LeetCode_30_Day_Challenge
//{
//    class Program
//    {
//        static List<int> _lefts;
//        static List<int> _rights;
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//            TreeNode root = new TreeNode(4);
//            root.left = new TreeNode(7);
//            root.right = new TreeNode(3);
//            root.right.left = new TreeNode(-9);
//            root.right.left.left = new TreeNode(9);
//            root.right.left.left.left = new TreeNode(6);
//            root.right.left.left.left.left = new TreeNode(0);
//            root.right.left.left.left.right = new TreeNode(1);
//            root.right.left.left.left.right = new TreeNode(6);
//            root.right.left.left.left.right.left = new TreeNode(4);
//            root.right.left.right = new TreeNode(-7);
//            root.right.left.right.left = new TreeNode(-6);
//            root.right.left.right.left.left = new TreeNode(5);
//            root.right.left.right.right = new TreeNode(-6);
//            root.right.left.right.right.left = new TreeNode(9);
//            root.right.left.right.right.left.left = new TreeNode(-2);

//            _lefts = new List<int>();
//            _rights = new List<int>();
//            int diameter = DiameterOfBinaryTree(root);
//        }

//        public static int DiameterOfBinaryTree(TreeNode root)
//        {
//            int diameter = LeftHeight(root?.left) + RightHeight(root?.right);
//            return diameter;
//        }

//        public static int LeftHeight(TreeNode root)
//        {
//            if (root == null) return 0;
//            int leftHt = LeftHeight(root.left);
//            int rightHt = LeftHeight(root.right);
//            _lefts.Add(Math.Max(leftHt, rightHt) + 1);
//            return Math.Max(leftHt, rightHt) + 1;
//        }
//        public static int RightHeight(TreeNode root)
//        {
//            if (root == null) return 0;

//            int leftHt = RightHeight(root.left);
//            int rightHt = RightHeight(root.right);
//            _rights.Add(Math.Max(leftHt, rightHt) + 1);
//            return Math.Max(leftHt, rightHt) + 1;
//        }
//    }

//    public class TreeNode
//    {
//        public int val;
//        public TreeNode left;
//        public TreeNode right;
//        public TreeNode(int x) { val = x; }
//    }
//}

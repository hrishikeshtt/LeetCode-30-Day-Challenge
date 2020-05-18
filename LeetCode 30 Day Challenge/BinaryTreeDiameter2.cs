//using System;

//namespace LeetCode_30_Day_Challenge
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//            TreeNode root = new TreeNode(3);
//            root.left = new TreeNode(2);
//            root.left.right = new TreeNode(4);
//            root.left.right.left = new TreeNode(1);
//            int diameter = DiameterOfBinaryTree(root);
//        }

//        public static int DiameterOfBinaryTree(TreeNode root)
//        {
//            if (root != null)
//            {
//                int leftSideRadius = GetLeftSideRadius(root.left);
//                int rightRadius = GetRightSideRadius(root.right);
//                return leftSideRadius + rightRadius;
//            }
//            return 0;

//        }

//        private static int GetRightSideRadius(TreeNode right)
//        {
//            int rightSideRadius = 0;
//            int leftSideRadius = 0;
//            if (right?.left != null)
//            {
//                leftSideRadius = GetRightSideRadius(right.left);
//            }
//            while (right != null)
//            {
//                rightSideRadius++;
//                right = right.left;
//            }
//            return leftSideRadius > rightSideRadius ? leftSideRadius : rightSideRadius;
//        }

//        private static int GetLeftSideRadius(TreeNode left)
//        {
//            int leftSideRadius = 0;
//            int rightSideRadius = 0;
//            if (left?.right != null)
//            {
//                rightSideRadius = GetRightSideRadius(left.right);
//            }
//            while (left != null)
//            {
//                leftSideRadius++;
//                left = left.left;
//            }

//            return leftSideRadius > rightSideRadius ? leftSideRadius : rightSideRadius;
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

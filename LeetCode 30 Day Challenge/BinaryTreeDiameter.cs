//using System;

//namespace LeetCode_30_Day_Challenge
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//            int[] stones = { 1 };
//            TreeNode root = new TreeNode(3);
//            root.left = new TreeNode(2);
//            root.left.left = new TreeNode(5);
//            root.left.right = new TreeNode(4);
//            root.left.right.right = new TreeNode(1);
//            int lastStoneWeight = DiameterOfBinaryTree(root);
//        }

//        public static int DiameterOfBinaryTree(TreeNode root)
//        {
//            if (root != null)
//            {
//                int leftSideLength = 0;
//                int rightSideLength = 0;
//                if (root.left != null)
//                {
//                    leftSideLength = CalculateLeftRadius(root.left, 1, root.left, 1);
//                }
//                if (root.right != null)
//                {
//                    rightSideLength = CalculateRightRadius(root.right, 1, root.right, 1);
//                }
//                return leftSideLength + rightSideLength;
//            }
//            return 0;

//        }

//        private static int CalculateLeftRadius(TreeNode left, int parentRadius, TreeNode immediateParent = null, int immediateParentRadius = 0)
//        {
//            if (left?.left != null)
//            {
//                return CalculateLeftRadius(left.left, parentRadius + 1, left, parentRadius);
//            }
//            if (left?.right != null)
//            {
//                return CalculateRightRadius(left.right, parentRadius + 1, left, parentRadius);
//            }
//            if (immediateParent?.right != null)
//            {
//                return CalculateRightRadius(immediateParent.right, parentRadius, left, parentRadius);
//            }

//            return parentRadius;
//        }

//        private static int CalculateRightRadius(TreeNode right, int parentRadius, TreeNode immediateParent = null, int immediateParentRadius = 0)
//        {
//            if (right?.left != null)
//            {
//                return CalculateLeftRadius(right.left, parentRadius + 1, right);
//            }
//            if (right?.right != null)
//            {
//                return CalculateRightRadius(right.right, parentRadius + 1, right, parentRadius);
//            }
//            if (immediateParent?.right != null)
//            {
//                return CalculateRightRadius(immediateParent.right, immediateParentRadius + 1, right, parentRadius);
//            }
//            return parentRadius;
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

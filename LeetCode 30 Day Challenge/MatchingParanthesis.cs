//using System;
//using System.Collections.Generic;

//namespace LeetCode_30_Day_Challenge
//{
//    class Program
//    {

//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//            string s = ")(";
//            bool isValid = CheckValidString(s);
//        }

//        private static bool CheckValidString(string s)
//        {
//            if (s.Length > 0 && (s[0] == '(' || s[0] == '*') && (s[s.Length - 1] == ')' || s[s.Length - 1] == '*'))
//            {
//                int leftPCount = 0;
//                int rightPCount = 0;
//                int starCount = 0;
//                for (int i = 0; i < s.Length; i++)
//                {
//                    if (s[i] == '(')
//                        leftPCount++;
//                    else if (s[i] == ')')
//                        rightPCount++;
//                    else if (s[i] == '*')
//                        starCount++;
//                }
//                if (leftPCount == rightPCount)
//                    return true;
//                else
//                {
//                    int min = Math.Min(leftPCount, rightPCount);
//                    int max = Math.Max(leftPCount, rightPCount);
//                    if (min + starCount >= max)
//                        return true;
//                }
//            }
//            else
//            {
//                if (string.IsNullOrEmpty(s) || s == "*")
//                    return true;
//            }
//            return false;
//        }
//    }
//}

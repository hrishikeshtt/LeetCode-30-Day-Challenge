using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_30_Day_Challenge
{
    class RemoveKDigits
    {
        // Took help from discuss forum
        // https://leetcode.com/explore/challenge/card/may-leetcoding-challenge/535/week-2-may-8th-may-14th/3328/
        // Thought of great logic
        static void MainRemoveKDigits(string[] args)
        {
            Console.WriteLine("Hello, world!");
            string kDigitsRemoved = RemoveKdigits("121130", 2);

        }
        public static string RemoveKdigits(string num, int k)
        {
            if (num.Length == k)
                return "0";
            if (k == 0)
                return num;
            Stack<char> stack = new Stack<char>();
            foreach (char n in num)
            {
                while (k > 0 && stack.Count > 0 && stack.First() > n)
                {
                    stack.Pop();
                    k--;
                }
                stack.Push(n);
            }
            if (k > 0)
                while (k-- > 0)
                    stack.Pop();
            List<char> chars = new List<char>();
            while (stack.Count > 0)
            {
                chars.Add(stack.Pop());
            }
            chars.Reverse();
            string result = string.Join("", chars);
            if (result.Any(n => n != '0'))
                return result.TrimStart('0');
            return "0";
        }
    }
}

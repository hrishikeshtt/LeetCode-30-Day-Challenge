using System;
using System.Linq;

namespace LeetCode_30_Day_Challenge
{
    class SingleNonDuplicate
    {
        // Accepted
        // Room for improvement
        // https://leetcode.com/explore/challenge/card/may-leetcoding-challenge/535/week-2-may-8th-may-14th/3327/
        static void MainSingleNonDuplicate(string[] args)
        {
            Console.WriteLine("Hello, world!");
            int[] nums = { 3, 3, 7, 7, 10, 11, 11 };
            int singleNonDuplicate = SingleNonDuplicateFn(nums);
        }
        public static int SingleNonDuplicateFn(int[] nums)
        {
            int singleDigitSum = 0;
            for (int index = 0; index < nums.Length; index += 2)
            {
                singleDigitSum += nums[index];
            }
            return (singleDigitSum * 2) - nums.Sum();

        }
    }
}

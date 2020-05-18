using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_30_Day_Challenge
{
    class MajorityElement
    {

        // Completed
        // https://leetcode.com/explore/challenge/card/may-leetcoding-challenge/534/week-1-may-1st-may-7th/
        // Array can be sorted and solved
        static void MainMajorityElement(string[] args)
        {
            Console.WriteLine("Hello, world!");
            int[] input = { 3, 3, 4 };
            int firstUniqueCharacterIndex = MajorityElementFn(input);
        }
        public static int MajorityElementFn(int[] nums)
        {
            Dictionary<int, int> numbersCount = new Dictionary<int, int>();
            int majority = nums.Length / 2;
            int majorityElement = 0;
            for (int forwardIndex = 0, backwardIndex = nums.Length - 1; forwardIndex < nums.Length; forwardIndex++, backwardIndex--)
            {
                if (backwardIndex >= forwardIndex)
                {
                    if (!numbersCount.ContainsKey(nums[forwardIndex]))
                    {
                        numbersCount.Add(nums[forwardIndex], 0);
                    }
                    if (!numbersCount.ContainsKey(nums[backwardIndex]))
                    {
                        numbersCount.Add(nums[backwardIndex], 0);
                    }
                    if (nums[forwardIndex] == nums[backwardIndex])
                    {
                        numbersCount[nums[forwardIndex]] += 2;
                    }
                    else
                    {
                        numbersCount[nums[forwardIndex]] += 1;
                        numbersCount[nums[backwardIndex]] += 1;
                    }
                    if (numbersCount.Any(numberCount => numberCount.Value > majority))
                    {
                        majorityElement = numbersCount.Where(numberCount => numberCount.Value > majority).FirstOrDefault().Key;
                        break;
                    }
                }

            }
            return majorityElement;
        }
    }


}

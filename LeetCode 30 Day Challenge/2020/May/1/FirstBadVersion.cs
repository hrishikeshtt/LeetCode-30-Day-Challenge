using System;

namespace LeetCode_30_Day_Challenge
{
    class FirstBadVersion : VersionControl2
    {
        //Completed
        // https://leetcode.com/explore/challenge/card/may-leetcoding-challenge/534/week-1-may-1st-may-7th/3316/
        static void MainFirstBadVersion(string[] args)
        {
            Console.WriteLine("Hello, world!");
            int firstBadVersion = FirstBadVersion2(2126753390);
        }
        public static int FirstBadVersion2(int n, int start = 1, int end = 0)
        {
            if (IsBadVersion(start))
                return start;
            if (end == 0)
                end = n;
            int middle = (start / 2) + (end / 2) + 1;
            bool isMiddleBadVersion = IsBadVersion(middle);
            bool isMiddlePrevBadVersion = IsBadVersion(middle - 1);
            if (!(isMiddleBadVersion == true && isMiddlePrevBadVersion == false))
            {
                if (isMiddleBadVersion)
                {
                    end = middle;
                }
                else
                {
                    start = middle;
                }
                return FirstBadVersion2(n, start, end);
            }
            return middle;
        }

    }

    internal class VersionControl2
    {
        public static bool IsBadVersion(int n)
        {
            if (n >= 1702766719)
                return true;
            return false;
        }
    }
}

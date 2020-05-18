using System;
using System.Linq;

namespace LeetCode_30_Day_Challenge
{
    class JwelsAndStones
    {
        // Completed
        // https://leetcode.com/explore/challenge/card/may-leetcoding-challenge/534/week-1-may-1st-may-7th/3317/
        static void MainJwelsAndStones(string[] args)
        {
            Console.WriteLine("Hello, world!");
            int firstUniqueCharacterIndex = NumJewelsInStones("aA", "AAAAAA");
        }
        public static int NumJewelsInStones(string J, string S)
        {
            char[] jewels = J.ToCharArray();
            int jewelCount = 0;
            foreach (char stone in S)
            {
                if (jewels.Contains(stone))
                    jewelCount += 1;
            }
            return jewelCount;
        }
    }


}

using System;
using System.Linq;

namespace LeetCode_30_Day_Challenge
{
    class TownJudge
    {
        // Completed
        // Room for improvement; execution time can be reduced
        // https://leetcode.com/explore/challenge/card/may-leetcoding-challenge/535/week-2-may-8th-may-14th/3325/
        static void MainTownJudge(string[] args)
        {
            Console.WriteLine("Hello, world!");
            int[][] trust = new int[5][];
            trust[0] = new int[2] { 1, 3 };
            trust[1] = new int[2] { 1, 4 };
            trust[2] = new int[2] { 2, 3 };
            trust[3] = new int[2] { 2, 4 };
            trust[4] = new int[2] { 4, 3 };
            int judge = FindJudge(4, trust);

        }

        public static int FindJudge(int N, int[][] trust)
        {
            if (trust.Length > 0)
            {
                int dummyJudge = trust.GroupBy(t => t[1]).ToList().Where(t => t.Count() == N - 1).Select(t => t.Key).FirstOrDefault();
                bool isDummyJudgeTrustsAnyone = trust.Any(t => t[0] == dummyJudge);
                if (!isDummyJudgeTrustsAnyone && dummyJudge != 0)
                    return dummyJudge;
                return -1;
            }
            return N;
        }
    }
}

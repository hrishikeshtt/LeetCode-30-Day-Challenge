using System;
using System.Linq;

namespace LeetCode_30_Day_Challenge
{
    class RansomeNote
    {
        // Completed
        //https://leetcode.com/explore/challenge/card/may-leetcoding-challenge/534/week-1-may-1st-may-7th/3318/
        static void MainRansomeNote(string[] args)
        {
            Console.WriteLine("Hello World!");
            string ransomNote = "";
            string magazine = "";
            bool canConstruct = CanConstruct(ransomNote, magazine);
        }
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            var charGroups = ransomNote.GroupBy(c => c).ToList();
            bool canConstruct = true;
            foreach (var charGroup in charGroups)
            {
                int magazineCharCount = magazine.Count(x => x == charGroup.Key);
                if (magazineCharCount >= charGroup.Count())
                {
                    canConstruct = canConstruct && true;
                }
                else
                {
                    canConstruct = canConstruct && false;
                }
            }
            return canConstruct;

        }
        public static string Alphabetize(string s)
        {
            char[] a = s.ToCharArray();
            Array.Sort(a);
            return new string(a);
        }
    }
}

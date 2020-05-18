using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_30_Day_Challenge
{
    class FirstUniqueCharacter
    {

        // Completed
        //https://leetcode.com/explore/challenge/card/may-leetcoding-challenge/534/week-1-may-1st-may-7th/3320/
        static void MainFirstUniqueCharacter(string[] args)
        {
            Console.WriteLine("Hello, world!");
            int firstUniqueCharacterIndex = FirstUniqChar("eetcode");
        }
        public static int FirstUniqChar(string s)
        {
            int firstUniqueCharacterIndex = -1;
            Dictionary<char, List<int>> charIndexes = new Dictionary<char, List<int>>();
            for (int index = 0; index < s.Length; index++)
            {
                if (!charIndexes.ContainsKey(s[index]))
                {
                    List<int> indexes = new List<int>();
                    indexes.Add(index);
                    charIndexes.Add(s[index], indexes);
                }
                else
                {
                    charIndexes[s[index]].Add(index);
                }
            }
            bool isUniqCharAvailable = charIndexes.Any(charIndex => charIndex.Value.Count() == 1);
            if (isUniqCharAvailable)
            {
                firstUniqueCharacterIndex = charIndexes.Where(charIndex => charIndex.Value.Count() == 1).FirstOrDefault().Value.FirstOrDefault();
            }
            return firstUniqueCharacterIndex;
        }
    }


}

using System;

namespace LeetCode_30_Day_Challenge
{
    class NumberCompliment
    {
        // Completed
        //https://leetcode.com/explore/challenge/card/may-leetcoding-challenge/534/week-1-may-1st-may-7th/3319/
        static void MainNumberCompliment(string[] args)
        {
            Console.WriteLine("Hello, world!");
            int complement = FindComplement(5);
        }
        public static int FindComplement(int num)
        {
            string binaryString = Convert.ToString(num, 2);
            string complimentaryString = string.Empty;
            foreach (char binary in binaryString)
            {
                complimentaryString += (binary == '0' ? '1' : '0');
            }
            int complimentary = Convert.ToInt32(complimentaryString, 2);

            return complimentary;
        }
    }


}

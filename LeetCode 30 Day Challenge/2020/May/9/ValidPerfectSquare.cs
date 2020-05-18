using System;

namespace LeetCode_30_Day_Challenge
{
    class ValidPerfectSquare
    {
        // Completed
        // Lines can be reduced by using another logic : num/2 square upto and check
        // https://leetcode.com/explore/challenge/card/may-leetcoding-challenge/

        static void MainValidPerfectSquare(string[] args)
        {
            Console.WriteLine("Hello, world!");
            bool isPerfectSqure = IsPerfectSquare(121);

        }
        public static bool IsPerfectSquare(int num)
        {
            if (num == 0)
                return true;
            else if (num < 0)
                return false;

            int digitCount = 0;
            int numCopy = num;
            while (numCopy / 10 > 0)
            {
                digitCount++;
                numCopy = numCopy / 10;
            }

            if (numCopy != 0)
                digitCount++;

            if (digitCount % 2 != 0)
                digitCount++;

            int[] num2DigitSplitted = new int[digitCount / 2];
            int num2DigitSplittedIndex = digitCount / 2 - 1;

            while (num % 100 > 0)
            {
                num2DigitSplitted[num2DigitSplittedIndex] = num % 100;
                num2DigitSplittedIndex--;
                num = num / 100;
            }
            int quatient = 0;
            int divisor = 0;
            int reminder = 0;
            int dividend = num2DigitSplitted[0];
            num2DigitSplittedIndex = 0;
            while (num2DigitSplittedIndex < num2DigitSplitted.Length)
            {
                divisor = quatient * 2;
                for (int i = 9; i >= 0; i--)
                {
                    if (dividend >= (divisor * 10 + i) * i)
                    {
                        divisor = divisor * 10 + i;
                        quatient = quatient * 10 + i;
                        reminder = dividend - (divisor * i);
                        if (num2DigitSplittedIndex < num2DigitSplitted.Length - 1)
                        {
                            dividend = reminder * 100 + num2DigitSplitted[num2DigitSplittedIndex + 1];
                        }
                        else
                        {
                            dividend = dividend - (divisor * i);
                        }
                        break;
                    }
                }
                num2DigitSplittedIndex++;
            }
            if (dividend == 0)
                return true;
            return false;

        }
    }
}

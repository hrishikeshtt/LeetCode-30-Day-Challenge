using System;

namespace LeetCode_30_Day_Challenge
{
    class IsStraightLine
    {
        // Completed
        // https://leetcode.com/explore/challenge/card/may-leetcoding-challenge/535/week-2-may-8th-may-14th/3323/
        static void MainIsStraightLine(string[] args)
        {
            Console.WriteLine("Hello, world!");
            // Two-dimensional array.
            int[][] coordinates = new int[6][];
            coordinates[0] = new int[2] { -4, 3 };
            coordinates[1] = new int[2] { 1, 0 };
            coordinates[2] = new int[2] { 3, -1 };
            coordinates[3] = new int[2] { 0, -1 };
            coordinates[4] = new int[2] { -5, 2 };


            bool isStraightLine = CheckStraightLine(coordinates);
        }
        public static bool CheckStraightLine(int[][] coordinates)
        {
            if (coordinates.Length <= 2)
            {
                return true;
            }
            else
            {
                float y2 = coordinates[1][1];
                float y1 = coordinates[0][1];
                float x2 = coordinates[1][0];
                float x1 = coordinates[0][0];
                float previousSlope = (y2 - y1) / (x2 - x1);

                bool isStraightLine = true;
                for (int index = 2; index < coordinates.Length; index++)
                {
                    y2 = coordinates[index][1];
                    y1 = coordinates[index - 1][1];
                    x2 = coordinates[index][0];
                    x1 = coordinates[index - 1][0];
                    float slope = (y2 - y1) / (x2 - x1);
                    if (previousSlope != slope)
                    {
                        isStraightLine = false;
                        break;
                    }
                    previousSlope = slope;
                }
                return isStraightLine;
            }
        }
    }
}

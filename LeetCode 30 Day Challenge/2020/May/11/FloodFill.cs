using System;
using System.Collections.Generic;

namespace LeetCode_30_Day_Challenge
{
    class FloodFill
    {
        // Accepted
        // https://leetcode.com/explore/challenge/card/may-leetcoding-challenge/535/week-2-may-8th-may-14th/3326/
        // Self greate achievment
        // Flood fil
        static void FloodFillMain(string[] args)
        {
            Console.WriteLine("Hello, world!");
            int[][] image = new int[3][];
            image[0] = new int[3] { 1, 1, 1 };
            image[1] = new int[3] { 1, 1, 0 };
            image[2] = new int[3] { 1, 0, 1 };
            int[][] coloredImage = FloodFillFn(image, 1, 1, 2);

        }

        public static int[][] FloodFillFn(int[][] image, int sr, int sc, int newColor, int sourceColor = -1, List<KeyValuePair<int, int>> visitedIndices = null)
        {
            if (sr >= 0 && sr < image.Length && sc >= 0 && sc < image[0].Length)
            {
                if (visitedIndices == null)
                {
                    visitedIndices = new List<KeyValuePair<int, int>>();
                }
                KeyValuePair<int, int> currentPixelIndex = new KeyValuePair<int, int>(sr, sc);
                if (!visitedIndices.Contains(currentPixelIndex))
                {
                    visitedIndices.Add(currentPixelIndex);
                    if (sourceColor == -1)
                    {
                        sourceColor = image[sr][sc];
                    }
                    if (image[sr][sc] == sourceColor)
                    {
                        image[sr][sc] = newColor;
                    }

                    if (sr >= 0 && sr < image.Length && sc - 1 >= 0 && sc - 1 < image[0].Length)
                        if (image[sr][sc - 1] == sourceColor)
                            FloodFillFn(image, sr, sc - 1, newColor, sourceColor, visitedIndices);

                    if (sr - 1 >= 0 && sr - 1 < image.Length && sc >= 0 && sc < image[0].Length)
                        if (image[sr - 1][sc] == sourceColor)
                            FloodFillFn(image, sr - 1, sc, newColor, sourceColor, visitedIndices);

                    if (sr >= 0 && sr < image.Length && sc + 1 >= 0 && sc + 1 < image[0].Length)
                        if (image[sr][sc + 1] == sourceColor)
                            FloodFillFn(image, sr, sc + 1, newColor, sourceColor, visitedIndices);

                    if (sr + 1 >= 0 && sr + 1 < image.Length && sc >= 0 && sc < image[0].Length)
                        if (image[sr + 1][sc] == sourceColor)
                            FloodFillFn(image, sr + 1, sc, newColor, sourceColor, visitedIndices);
                }
            }
            return image;
        }
    }
}

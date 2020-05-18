//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace LeetCode_30_Day_Challenge
//{
//    class Program
//    {

//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//            int[] nums = { 0, 1, 1 };
//            int maxlength = FindMaxLength(nums);
//        }

//        private static int FindMaxLength(int[] nums)
//        {
//            List<KeyVal<int, int>> zeroOneCounts = new List<KeyVal<int, int>>();
//            List<int> numsList = nums.ToList();
//            List<KeyVal<int, int>> result = numsList.Aggregate(new List<KeyVal<int, int>>(), (current, next) =>
//            {
//                if (zeroOneCounts.Count == 0)
//                {
//                    KeyVal<int, int> starter = new KeyVal<int, int>(next, 0);
//                    zeroOneCounts.Add(starter);
//                }
//                KeyVal<int, int> lastKeyValuePair = zeroOneCounts.LastOrDefault();
//                if (lastKeyValuePair.Key != next)
//                {
//                    KeyVal<int, int> newKeyValuePair = new KeyVal<int, int>(next, 1);
//                    zeroOneCounts.Add(newKeyValuePair);
//                }
//                else
//                {
//                    lastKeyValuePair.Value += 1;
//                }
//                return current;
//            });
//            var max = zeroOneCounts.Where(x => x.Value == zeroOneCounts.Max(y => y.Value)).FirstOrDefault();
//            int maxIndex = zeroOneCounts.IndexOf(max);

//            int sumDiff = CalCulateContiguousLength(zeroOneCounts);
//            if (sumDiff > 0)
//            {
//                return sumDiff;
//            }
//            else if (maxIndex == zeroOneCounts.Count - 1)
//            {
//                zeroOneCounts.Reverse();
//                int contiguousLength = CalCulateContiguousLength(zeroOneCounts);
//                return contiguousLength;
//            }
//            else
//            {
//                for (int i = 1; i < zeroOneCounts.Count; i++)
//                {
//                    List<int> contigousLengths = new List<int>();
//                    if (zeroOneCounts[i - 1].Value - zeroOneCounts[i].Value < 0)
//                    {
//                        int contiguous = zeroOneCounts[i].Value + zeroOneCounts[i - 1].Value - (zeroOneCounts[i].Value - zeroOneCounts[i - 1].Value);
//                        contigousLengths.Add(contiguous);
//                    }
//                    else
//                    {
//                        contigousLengths.Add(zeroOneCounts[i].Value - zeroOneCounts[i - 1].Value);
//                    }
//                    return contigousLengths.Max();
//                }
//            }
//            return 0;
//        }

//        private static int CalCulateContiguousLength(List<KeyVal<int, int>> zeroOneCounts)
//        {
//            int diff = 0;
//            int sum = 0;
//            List<int> sumZeroIndices = new List<int>();
//            for (int i = 0; i < zeroOneCounts.Count; i++)
//            {
//                if (i % 2 != 0)
//                {
//                    zeroOneCounts[i].Value = 0 - zeroOneCounts[i].Value;
//                }
//                diff = diff + zeroOneCounts[i].Value;
//                if (diff == 0)
//                    sumZeroIndices.Add(i);
//                if (i % 2 != 0)
//                {
//                    zeroOneCounts[i].Value = zeroOneCounts[i].Value * -1;
//                }
//                sum += zeroOneCounts[i].Value;
//            }
//            if (diff < 0)
//                return sum + diff;
//            return sum - diff;
//        }
//    }
//    public class KeyVal<TKey, TVal>
//    {
//        public TKey Key { get; set; }
//        public TVal Value { get; set; }

//        public KeyVal() { }

//        public KeyVal(TKey key, TVal val)
//        {
//            Key = key;
//            Value = val;
//        }
//    }
//}

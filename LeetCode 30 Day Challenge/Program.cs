﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_30_Day_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = FizzBuzz(15);
            Console.ReadKey();

        }

        public static IList<string> FizzBuzz(int n)
        {
            IList<string> fizzBuzzes = new List<string>();
            for(int i = 1; i<=n;i++)
            {
                if (i % 15 == 0)
                    fizzBuzzes.Add("FizzBuzz");

                else if (i % 5 == 0)
                    fizzBuzzes.Add("Buzz");

                else if (i % 3 == 0)
                    fizzBuzzes.Add("Fizz");
                else
                    fizzBuzzes.Add(i.ToString());

                
            }
            return fizzBuzzes;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_30_Day_Challenge
{
    public class MinStack
    {
        List<int> _stack;
        public MinStack()
        {
            _stack = new List<int>();
        }

        public void Push(int x)
        {
            _stack.Add(x);
        }


        public void Pop()
        {
            _stack.RemoveAt(_stack.Count - 1);
        }

        public int Top()
        {
            return _stack[_stack.Count - 1];
        }

        public int GetMin()
        {
            return _stack.Min();
        }
    }
}

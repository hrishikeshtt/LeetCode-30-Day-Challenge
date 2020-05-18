using System;
using System.Collections.Generic;

namespace LeetCode_30_Day_Challenge
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode MiddleNode(ListNode head)
        {
            List<ListNode> listNodes = new List<ListNode>();            
            while (head.next != null)
            {
                listNodes.Add(head);
                head = head.next;                
            }
            listNodes.Add(head);
            return listNodes[listNodes.Count/2];
        }
    }
}

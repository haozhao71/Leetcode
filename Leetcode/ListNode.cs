using System;
using System.Collections;

namespace Leetcode
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public ArrayList ToIntArray()
        {
            var result = new ArrayList();
            var node = this;
            while(node != null)
            {
                result.Add(node.val);
                node = node.next;
            }
            return result;
        }

        public ListNode Reverse()
        {
            ListNode newHeadNode = null;
            ListNode oldHeadNode = this;
            while(oldHeadNode.next != null)
            {
                var temp = oldHeadNode.next;
                oldHeadNode.next = newHeadNode;
                newHeadNode = oldHeadNode;
                oldHeadNode = temp;
            }
            oldHeadNode.next = newHeadNode;
            newHeadNode = oldHeadNode;
            return newHeadNode;
        }
    }
}

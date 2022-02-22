using System;
using System.Collections;

//Leetcode 002 Add Two Numbers
//You are given two non-empty linked lists representing two non-negative integers.
//The digits are stored in reverse order, and each of their nodes contains a single digit.
//Add the two numbers and return the sum as a linked list.
//You may assume the two numbers do not contain any leading zero, except the number 0 itself.

namespace Leetcode
{
    public class TwoNums
    {
        public ListNode firstNode;
        public ListNode secondNode;

        public TwoNums(ListNode firstNode, ListNode secondNode)
        {
            this.firstNode = firstNode ?? throw new ArgumentNullException();
            this.secondNode = secondNode ?? throw new ArgumentNullException();
        }

        

        public ListNode Add()
        {
            ListNode prevNode = null;
            ListNode currentNode = null;
            int tempVal = 0;
            int val;
            while (firstNode != null && secondNode != null)
            {
                val = firstNode.val + secondNode.val + tempVal;
                tempVal = 0;
                if (val >= 10)
                {
                    val -= 10;
                    tempVal = 1;
                }
                currentNode = new ListNode(val, prevNode);
                prevNode = currentNode;
                firstNode = firstNode.next;
                secondNode = secondNode.next;
            }
            while (firstNode != null)
            {
                val = firstNode.val + tempVal;
                tempVal = 0;
                if (val >= 10)
                {
                    val -= 10;
                    tempVal = 1;
                }
                currentNode = new ListNode(val, prevNode);
                prevNode = currentNode;
                firstNode = firstNode.next;
                
            }
            while (secondNode != null)
            {
                val = firstNode.val + tempVal;
                tempVal = 0;
                if (val >= 10)
                {
                    val -= 10;
                    tempVal = 1;
                }
                currentNode = new ListNode(val, prevNode);
                prevNode = currentNode;
                secondNode = secondNode.next;
            }
            if (tempVal == 1)
            {
                currentNode = new ListNode(tempVal, prevNode);
            }
            return currentNode.Reverse();
        }
    }
}

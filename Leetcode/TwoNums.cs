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
            ListNode headNode = new ListNode(0);
            ListNode currentNode = headNode;
            int tempVal = 0;
            int sum;
            while (firstNode != null || secondNode != null)
            {
                sum = 0;
                if(firstNode != null)
                {
                    sum += firstNode.val;
                    firstNode = firstNode.next;
                }
                if(secondNode != null)
                {
                    sum += secondNode.val;
                    secondNode = secondNode.next;
                }
                sum += tempVal;

                tempVal = sum / 10;
                sum = sum % 10;
                currentNode.next = new ListNode(sum);
                currentNode = currentNode.next;
            }
            if (tempVal == 1)
            {
                currentNode.next = new ListNode(tempVal);
            }
            return headNode.next;
        }
    }
}

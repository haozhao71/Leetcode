using System;
using System.Collections.Generic;

//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

//You may assume that each input would have exactly one solution, and you may not use the same element twice.

//You can return the answer in any order.

namespace Leetcode
{
    public class TwoSum
    {
        public TwoSum()
        {

        }

        public int[] GetResult(int[] nums, int target)
        {
            if(nums == null)
            {
                throw new ArgumentNullException("nums should not be null");
            }
            if(nums.Length < 2)
            {
                throw new ArgumentException("nums length should more than 1");
            }
            Dictionary<int, int> dictionary = new Dictionary<int, int> { };
            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                if (dictionary.ContainsKey(diff))
                {
                    return new int[] { dictionary[diff], i};
                }
                else
                {
                    dictionary[nums[i]] = i;
                }   
            }
            return new int[] { };
        }
    }
}

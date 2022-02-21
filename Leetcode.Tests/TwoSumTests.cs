using System;
using Xunit;
using FluentAssertions;


namespace Leetcode.Tests
{
    public class TwoSumTests
    {
        [Fact]
        public void Should_Throw_NullReferenceException_When_InputNums_Is_Null()
        {
            TwoSum twoSum = new TwoSum();
            Action action = () => twoSum.GetResult(null, 0);
            action.Should().Throw<ArgumentNullException>("nums should not be null");
        }

        [Theory]
        [InlineData(new int[] { })]
        [InlineData(new int[] { 1 })]
        public void Should_Throw_ArrgumentException_When_InputNums_Length_Less_Than_Two(int[] nums)
        {
            TwoSum twoSum = new TwoSum();
            Action action = () => twoSum.GetResult(nums, 0);
            action.Should().Throw<ArgumentException>("nums length should more than 1");
        }


        [Theory]
        [InlineData(new int[] { 1, 2 }, 3)]
        [InlineData(new int[] { 2, 3 }, 5)]
        public void Should_ReturnIndex_When_InputNumsLength_Is_Two(int[] nums, int target)
        {
            TwoSum twoSum = new TwoSum();
            var result = twoSum.GetResult(nums, target);
            result.Should().BeEquivalentTo(new int[] { 0, 1 });

        }


        [Theory]
        [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        public void Should_ReturnIndex_When_InputNumsLength_Is_MoreThanTwo(int[] nums, int target, int[] results)
        {
            TwoSum twoSum = new TwoSum();
            var result = twoSum.GetResult(nums, target);
            result.Should().BeEquivalentTo(results);
        }
    }
}

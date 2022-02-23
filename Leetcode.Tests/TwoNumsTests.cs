using System;
using Xunit;
using FluentAssertions;
using System.Collections.Generic;
using System.Collections;

namespace Leetcode.Tests
{
    public class TwoNumsTests
    {
        public static IEnumerable<object[]> ArgumentNullExceptionData =>
            new List<object[]>
            {
                new object[] {null, new ListNode()},
                new object[] {new ListNode(), null},
                new object[] {null, null},
            };

        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] {new ListNode(0,new ListNode(1, null)), new ListNode(1, new ListNode(3, null)) },
            };

        [Theory]
        [MemberData(nameof(ArgumentNullExceptionData))]
        public void Should_Throw_ArgumentNullException_When_Input_Is_Null(ListNode firstNode, ListNode secondNode)
        {
            Action action = () => new TwoNums(firstNode, secondNode);

            action.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void Should_Return_Zero_When_Input_Both_Zero()
        {
            ListNode firstNode = new ListNode();
            ListNode secondNode = new ListNode();

            TwoNums twoNums = new TwoNums(firstNode, secondNode);

            var actual = twoNums.Add().ToIntArray();
            Assert.Equal(new ArrayList() { 0 }, actual);
        }

        [Fact]
        public void Should_Return_Result_When_TwoNumsLength_Is_Equal()
        {
            ListNode firstNode = new ListNode(2, new ListNode(4, new ListNode(3, null)));
            ListNode secondNode = new ListNode(5, new ListNode(6, new ListNode(4, null)));

            TwoNums twoNums = new TwoNums(firstNode, secondNode);

            var actual = twoNums.Add();
            var _actual = actual.ToIntArray();
            Assert.Equal(new ArrayList() { 7,0,8 }, _actual);
        }

        [Fact]
        public void Should_Return_Result_When_TwoNumsLength_Is_Not_Equal()
        {
            ListNode firstNode = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, null)))))));
            ListNode secondNode = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, null))));

            TwoNums twoNums = new TwoNums(firstNode, secondNode);

            var actual = twoNums.Add().ToIntArray();
            Assert.Equal(new ArrayList() {8,9,9,9,0,0,0,1 }, actual);
        }

        [Fact]
        public void Should_Return_Result_When_TwoNumsLength_Is_Not_Equal_2()
        {
            ListNode firstNode = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, null))));
            ListNode secondNode = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, null)))))));

            TwoNums twoNums = new TwoNums(firstNode, secondNode);

            var actual = twoNums.Add().ToIntArray();
            //Assert.Equal(new ArrayList() { 8, 9, 9, 9, 0, 0, 0, 1 }, actual);
            actual.Should().BeEquivalentTo(new ArrayList() { 8, 9, 9, 9, 0, 0, 0, 1 });
        }
    }

    
           
}

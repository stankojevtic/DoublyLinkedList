using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using DoublyLinkedList.App.DoublyLinkedList;
using DoublyLinkedList.App.Interfaces;
using DoublyLinkedList.App.Services;
using Moq;

namespace DoublyLinkedList.App.Tests.DoublyLinkedList
{
    public class DoubleLinkedListTests
    {
        private static Mock<ISortService> _sortService;

        public DoubleLinkedListTests()
        {
            _sortService = new Mock<ISortService>();
        }


        [Fact]
        public void AddFirst_WhenListIsEmpty_Success()
        {
            var doublyLinkedList = new DoubleLinkedList<int>(_sortService.Object);

            var value = 10;
            doublyLinkedList.AddFirst(value);

            Assert.Equal(doublyLinkedList.First.Data, value);
            Assert.Equal(doublyLinkedList.Last.Data, value);
            Assert.Null(doublyLinkedList.Last.Previous);
            Assert.Null(doublyLinkedList.Last.Next);
            Assert.Null(doublyLinkedList.First.Previous);
            Assert.Null(doublyLinkedList.First.Next);
        }

        [Fact]
        public void AddFirst_WhenListContainsTwoItems_Success()
        {
            var doublyLinkedList = new DoubleLinkedList<int>(_sortService.Object);

            var value1 = 10;
            var value2 = 20;
            doublyLinkedList.AddFirst(value1);
            doublyLinkedList.AddFirst(value2);

            Assert.Equal(doublyLinkedList.First.Data, value2);
            Assert.Equal(doublyLinkedList.Last.Data, value1);
            Assert.NotNull(doublyLinkedList.Last.Previous);
            Assert.Null(doublyLinkedList.Last.Next);
            Assert.Null(doublyLinkedList.First.Previous);
            Assert.NotNull(doublyLinkedList.First.Next);
        }

        [Fact]
        public void AddLast_WhenListIsEmpty_Success()
        {
            var doublyLinkedList = new DoubleLinkedList<int>(_sortService.Object);

            var value = 10;
            doublyLinkedList.AddLast(value);

            Assert.Equal(doublyLinkedList.First.Data, value);
            Assert.Equal(doublyLinkedList.Last.Data, value);
            Assert.Null(doublyLinkedList.Last.Previous);
            Assert.Null(doublyLinkedList.Last.Next);
            Assert.Null(doublyLinkedList.First.Previous);
            Assert.Null(doublyLinkedList.First.Next);
        }

        [Fact]
        public void AddLast_WhenListContainsTwoItems_Success()
        {
            var doublyLinkedList = new DoubleLinkedList<int>(_sortService.Object);

            var value1 = 10;
            var value2 = 20;
            doublyLinkedList.AddLast(value1);
            doublyLinkedList.AddLast(value2);

            Assert.Equal(doublyLinkedList.First.Data, value1);
            Assert.Equal(doublyLinkedList.Last.Data, value2);
            Assert.NotNull(doublyLinkedList.Last.Previous);
            Assert.Null(doublyLinkedList.Last.Next);
            Assert.Null(doublyLinkedList.First.Previous);
            Assert.NotNull(doublyLinkedList.First.Next);
        }

        [Fact]
        public void Remove_WhenListContainsOneItem_Success()
        {
            var doublyLinkedList = new DoubleLinkedList<int>(_sortService.Object);

            var value1 = 10;
            doublyLinkedList.AddFirst(value1);
            doublyLinkedList.Remove(value1);

            Assert.Null(doublyLinkedList.Last);
            Assert.Null(doublyLinkedList.First);
        }

        [Fact]
        public void Remove_WhenRemovingLastItemInList_Success()
        {
            var doublyLinkedList = new DoubleLinkedList<int>(_sortService.Object);

            var value1 = 10;
            var value2 = 20;
            var value3 = 30;
            var value4 = 40;

            doublyLinkedList.AddFirst(value1);
            doublyLinkedList.AddFirst(value2);
            doublyLinkedList.AddFirst(value3);
            doublyLinkedList.AddFirst(value4);
            doublyLinkedList.Remove(value1);

            Assert.Equal(doublyLinkedList.First.Data, value4);
            Assert.Equal(doublyLinkedList.Last.Data, value2);
            Assert.NotNull(doublyLinkedList.Last.Previous);
            Assert.Null(doublyLinkedList.Last.Next);
            Assert.Null(doublyLinkedList.First.Previous);
            Assert.NotNull(doublyLinkedList.First.Next);
        }

        [Fact]
        public void Remove_WhenRemovingFirstItemInList_Success()
        {
            var doublyLinkedList = new DoubleLinkedList<int>(_sortService.Object);

            var value1 = 10;
            var value2 = 20;
            var value3 = 30;
            var value4 = 40;

            doublyLinkedList.AddFirst(value1);
            doublyLinkedList.AddFirst(value2);
            doublyLinkedList.AddFirst(value3);
            doublyLinkedList.AddFirst(value4);
            doublyLinkedList.Remove(value4);

            Assert.Equal(doublyLinkedList.First.Data, value3);
            Assert.Equal(doublyLinkedList.Last.Data, value1);
            Assert.NotNull(doublyLinkedList.Last.Previous);
            Assert.Null(doublyLinkedList.Last.Next);
            Assert.Null(doublyLinkedList.First.Previous);
            Assert.NotNull(doublyLinkedList.First.Next);
        }
    }
}


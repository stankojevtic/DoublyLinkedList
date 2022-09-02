using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using DoublyLinkedList.App.DoublyLinkedList;
using DoublyLinkedList.App.Services;

namespace DoublyLinkedList.App.Tests.DoublyLinkedList
{
    public class DoubleLinkedListTests
    {
        [Fact]
        public void AddFirst_WhenListIsEmpty_Success()
        {
            var sortService = new QuickSortService();

            var doublyLinkedList = new DoubleLinkedList<int>(sortService);

            doublyLinkedList.AddFirst(10);

            Assert.Equal(doublyLinkedList.First.Data, 10);
            Assert.Equal(doublyLinkedList.Last.Data, 10);
            Assert.Null(doublyLinkedList.Last.Previous);
            Assert.Null(doublyLinkedList.Last.Next);
            Assert.Null(doublyLinkedList.First.Previous);
            Assert.NotNull(doublyLinkedList.First.Next);
        }
    }
}


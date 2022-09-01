using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using DoublyLinkedList.App.DoublyLinkedList;

namespace DoublyLinkedList.App.Tests.DoublyLinkedList
{
    public class DoublyLinkedListTests
    {
        [Fact]
        public void AddFirst_WhenListIsEmpty_Success()
        {
            var doublyLinkedList = new DoubleLinkedList();

            doublyLinkedList.AddFirst(10);

            Assert.Equal(doublyLinkedList.First.Data, 10);
            Assert.Equal(doublyLinkedList.Last.Data, 10);
        }
    }
}


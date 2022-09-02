using System;
using DoublyLinkedList.App.DoublyLinkedList;
using DoublyLinkedList.App.Interfaces;
using DoublyLinkedList.App.Services;

namespace DoublyLinkedList.App.Tests.Services
{
    public class QuickSortServiceTests
    {

        [Fact]
        public void Sort_ShouldSortByValue_Success()
        {
            var quickSortService = new QuickSortService();

            var node = new Node<int>(10);
            node.Next = new Node<int>(20);
            node.Next.Previous = node;
            node.Next.Next = new Node<int>(15);
            node.Next.Next.Previous = node.Next.Next;

            quickSortService.Sort<int>(node);

            var actualResult = GetListOfNodes(node);
            var expectedResult = new List<int> { 10, 20, 15 };

            Assert.Equal(actualResult, expectedResult);
        }

        private List<int> GetListOfNodes(Node<int> node)
        {
            var result = new List<int>();

            while (node != null)
            {
                result.Add(node.Data);
                node = node.Next;
            }

            return result;
        }
    }
}


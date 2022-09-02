using System;
using DoublyLinkedList.App.DoublyLinkedList;
using DoublyLinkedList.App.Helpers;
using DoublyLinkedList.App.Interfaces;

namespace DoublyLinkedList.App.Services
{
    public class QuickSortService<T> : ISortService<Node<T>> where T : System.IComparable<T>
    {
        public void Sort(Node<T> first)
        {
            var last = NodeHelper<T>.FindLast(first);
            RecursiveQuickSort(last, first);
        }

        private Node<T> Partition(Node<T> first, Node<T> last)
        {
            var pivot = first.Data;

            var partitionNode = last.Previous;
            T temp;

            for (var i = last; i != first; i = i.Next)
            {
                if (i.Data.CompareTo(pivot) < 0)
                {
                    partitionNode = (partitionNode == null) ? last : partitionNode.Next;
                    temp = partitionNode.Data;
                    partitionNode.Data = i.Data;
                    i.Data = temp;
                }
            }
            partitionNode = (partitionNode == null) ? last : partitionNode.Next;
            temp = partitionNode.Data;
            partitionNode.Data = first.Data;
            first.Data = temp;

            return partitionNode;
        }

        private void RecursiveQuickSort(Node<T> first, Node<T> last)
        {
            if (first != null && last != first && last != first.Next)
            {
                var temp = Partition(first, last);
                RecursiveQuickSort(temp.Previous, last);
                RecursiveQuickSort(first, temp.Next);
            }
        }
    }
}


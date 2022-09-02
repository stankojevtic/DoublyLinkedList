using System;
using DoublyLinkedList.App.DoublyLinkedList;
using DoublyLinkedList.App.Helpers;
using DoublyLinkedList.App.Interfaces;

namespace DoublyLinkedList.App.Services
{
    public class QuickSortService : ISortService
    {
        public void Sort<T>(Node<T> first) where T : System.IComparable<T>
        {
            var last = NodeHelper<T>.FindLast(first);
            RecursiveQuickSort(last, first);
        }

        public void Sort<T>(T item)
        {
            throw new NotImplementedException();
        }

        private Node<T> Partition<T>(Node<T> first, Node<T> last) where T : System.IComparable<T>
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

        private void RecursiveQuickSort<T>(Node<T> first, Node<T> last) where T : System.IComparable<T>
        {
            if (first != null && last != first && last != first.Next)
            {
                var temp = Partition<T>(first, last);
                RecursiveQuickSort<T>(temp.Previous, last);
                RecursiveQuickSort<T>(first, temp.Next);
            }
        }
    }
}


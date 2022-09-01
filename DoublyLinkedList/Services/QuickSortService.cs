using System;
using DoublyLinkedList.App.DoublyLinkedList;
using DoublyLinkedList.App.Helpers;
using DoublyLinkedList.App.Interfaces;

namespace DoublyLinkedList.App.Services
{
    public class QuickSortService : ISortService<Node>
    {
        public void Sort(Node first)
        {
            var last = NodeHelper.FindLast(first);
            RecursiveQuickSort(last, first);
        }

        private Node Partition(Node first, Node last)
        {
            var pivot = first.Data;

            Node partitionNode = last.Previous;
            int temp;

            for (var i = last; i != first; i = i.Next)
            {
                if (i.Data <= pivot)
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

        private void RecursiveQuickSort(Node first, Node last)
        {
            if (first != null && last != first && last != first.Next)
            {
                Node temp = Partition(first, last);
                RecursiveQuickSort(temp.Previous, last);
                RecursiveQuickSort(first, temp.Next);
            }
        }
    }
}


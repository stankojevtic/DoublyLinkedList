using System;
using DoublyLinkedList.App.DoublyLinkedList;

namespace DoublyLinkedList.App.Interfaces
{
    public interface ISortService
    {
        void Sort<T>(Node<T> item) where T : System.IComparable<T>;
    }
}
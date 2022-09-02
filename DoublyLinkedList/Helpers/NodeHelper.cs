using System;
using DoublyLinkedList.App.DoublyLinkedList;

namespace DoublyLinkedList.App.Helpers
{
    public static class NodeHelper<T> where T : System.IComparable<T>
    {
        public static Node<T> FindLast(Node<T> node)
        {
            while (node.Next != null)
                node = node.Next;
            return node;
        }
    }
}


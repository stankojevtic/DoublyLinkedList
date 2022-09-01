using System;
using DoublyLinkedList.App.DoublyLinkedList;

namespace DoublyLinkedList.App.Helpers
{
    public static class NodeHelper
    {
        public static Node FindLast(Node node)
        {
            while (node.Next != null)
                node = node.Next;
            return node;
        }
    }
}


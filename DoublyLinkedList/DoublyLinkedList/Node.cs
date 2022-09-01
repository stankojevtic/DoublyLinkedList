using System;
namespace DoublyLinkedList.App.DoublyLinkedList
{
    public class Node
    {
        private int _data;
        public int Data
        {
            get => _data;
            set => _data = value;
        }

        private Node _next;
        public Node Next
        {
            get => _next;
            set => _next = value;
        }

        private Node _previous;
        public Node Previous
        {
            get => _previous;
            set => _previous = value;
        }

        public Node(int data) //Use T
        {
            Data = data;
        }
    }
}


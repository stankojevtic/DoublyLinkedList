using System;
namespace DoublyLinkedList.App.DoublyLinkedList
{
    public class Node<T> where T : System.IComparable<T>
    {
        private T _data;
        public T Data
        {
            get => _data;
            set => _data = value;
        }

        private Node<T> _next;
        public Node<T> Next
        {
            get => _next;
            set => _next = value;
        }

        private Node<T> _previous;
        public Node<T> Previous
        {
            get => _previous;
            set => _previous = value;
        }

        public Node(T data)
        {
            Data = data;
        }
    }
}


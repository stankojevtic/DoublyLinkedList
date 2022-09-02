using System;
using System.Collections;
using System.Xml.Linq;
using DoublyLinkedList.App.Interfaces;

namespace DoublyLinkedList.App.DoublyLinkedList
{
    public class DoubleLinkedList<T> : IEnumerable<Node<T>> where T : System.IComparable<T>
    {
        private Node<T> _first;
        public Node<T> First
        {
            get => _first;
            set => _first = value;
        }

        private Node<T> _last;
        public Node<T> Last
        {
            get => _last;
            set => _last = value;
        }

        private readonly ISortService _sortService;

        public DoubleLinkedList(ISortService sortService)
        {
            _sortService = sortService;
        }

        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = _first;

            if (_first == null)
            {
                _last = newNode;
            }
            else
            {
                _first.Previous = newNode;
            }

            _first = newNode;
        }

        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (_last == null)
            {
                _first = newNode;
            }
            else
            {
                newNode.Previous = _last;
                _last.Next = newNode;
            }

            _last = newNode;
        }

        public bool Remove(T value)
        {
            Node<T> currentNode = _first;

            while (currentNode != null)
            {
                if (currentNode.Data.Equals(value))
                {
                    if (currentNode.Next == null)
                    {
                        _last = currentNode.Previous;
                    }
                    else
                    {
                        currentNode.Next.Previous = currentNode.Previous;
                    }

                    if (currentNode.Previous == null)
                    {
                        _first = currentNode.Next;
                    }
                    else
                    {
                        currentNode.Previous.Next = currentNode.Next;
                    }

                    currentNode = null;
                    return true;
                }

                currentNode = currentNode.Next;
            }

            return false;
        }

        public void Sort()
        {
            _sortService.Sort<T>(_first);
        }

        public IEnumerator<Node<T>> GetEnumerator()
        {
            Node<T> current = _first;
            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
}
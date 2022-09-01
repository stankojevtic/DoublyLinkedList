using System;
using System.Collections;
using System.Xml.Linq;
using DoublyLinkedList.App.Interfaces;

namespace DoublyLinkedList.App.DoublyLinkedList
{
    public class DoubleLinkedList : IEnumerable<Node>
    {
        private Node _first;
        public Node First
        {
            get => _first;
            set => _first = value;
        }

        private Node _last;
        public Node Last
        {
            get => _last;
            set => _last = value;
        }

        private readonly ISortService<Node> _sortService;

        public DoubleLinkedList(ISortService<Node> sortService)
        {
            _sortService = sortService;
        }

        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
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

        public void AddLast(int data)
        {
            Node newNode = new Node(data);

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

        public bool Remove(int value)
        {
            Node currentNode = _first;

            while (currentNode != null)
            {
                if (currentNode.Data == value)
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
            _sortService.Sort(_first);
        }

        public IEnumerator<Node> GetEnumerator()
        {
            Node current = _first;
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
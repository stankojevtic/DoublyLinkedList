using System;
using System.Collections;
using System.Xml.Linq;

namespace DoublyLinkedList.App.DoublyLinkedList
{
    public class DoublyLinkedList : IEnumerable<Node> //where T : System.IComparable<T>
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

        public void QuickSort()
        {
            RecursiveQuickSort(_last, _first);
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
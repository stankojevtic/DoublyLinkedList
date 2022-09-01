using System;
using DoublyLinkedList.App.Models;

namespace DoublyLinkedList.App.Interfaces
{
    public interface IDoublyLinkedListService
    {
        void AddFirst(List<DoublyLinkedNode> doublyLinkedList, DoublyLinkedNode newNode);
        void AddLast(List<DoublyLinkedNode> doublyLinkedList, DoublyLinkedNode newNode);
        void Remove(List<DoublyLinkedNode> doublyLinkedList, DoublyLinkedNode node);
    }
}


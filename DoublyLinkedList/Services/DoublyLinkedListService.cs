//using System;
//using DoublyLinkedList.App.Interfaces;
//using DoublyLinkedList.App.Models;

//namespace DoublyLinkedList.App.Services
//{
//    public class DoublyLinkedListService : IDoublyLinkedListService
//    {
//        public void AddFirst(List<DoublyLinkedNode> doublyLinkedList, DoublyLinkedNode newNode)
//        {
//            if (doublyLinkedList.FirstOrDefault() == null)
//            {
//                doublyLinkedList.Add(newNode);
//            }
//            else
//            {
//                InsertBefore(doublyLinkedList, doublyLinkedList.First(), newNode);
//            }
//        }

//        public void AddLast(List<DoublyLinkedNode> doublyLinkedList, DoublyLinkedNode newNode)
//        {
//            if (doublyLinkedList.LastOrDefault() == null)
//            {
//                AddFirst(doublyLinkedList, newNode);
//            }
//            else
//            {
//                InsertAfter(doublyLinkedList, doublyLinkedList.Last(), newNode);
//            }
//        }

//        public void Remove(List<DoublyLinkedNode> doublyLinkedList, DoublyLinkedNode node)
//        {
//            //if (node.Previous == null)
//            //{
//            //    node.Next.Previous = null;
//            //    doublyLinkedList.Remove(node);
//            //    doublyLinkedList.First
//            //}
//        }

//        private void InsertBefore(List<DoublyLinkedNode> doublyLinkedList, DoublyLinkedNode node, DoublyLinkedNode newNode)
//        {
//            newNode.Next = node;

//            if (node.Previous == null)
//            {
//                doublyLinkedList.Insert(0, newNode);
//            }
//            else
//            {
//                newNode.Previous = node.Previous;
//                node.Previous.Next = newNode;
//            }

//            node.Previous = newNode;
//        }

//        private void InsertAfter(List<DoublyLinkedNode> doublyLinkedList, DoublyLinkedNode node, DoublyLinkedNode newNode)
//        {
//            newNode.Previous = node;

//            if (node.Next == null)
//            {
//                doublyLinkedList.Add(newNode);
//            }
//            else
//            {
//                newNode.Next = node.Next;
//                node.Next.Previous = newNode;
//            }

//            node.Next = newNode;
//        }
//    }
//}


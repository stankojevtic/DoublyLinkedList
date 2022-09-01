using DoublyLinkedList.App.Collections;
using DoublyLinkedList.App.Interfaces;
using DoublyLinkedList.App.Models;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    public static void Main(string[] args)
    {
        //setup DI
        //var serviceProvider = new ServiceCollection()
        //    .AddTransient<IDoublyLinkedListService, DoublyLinkedListService>()
        //    .BuildServiceProvider();
        //var doublyLinkedListService = serviceProvider.GetService<IDoublyLinkedListService>();

        //var doublyLinkedList = new List<DoublyLinkedNode>();

        //doublyLinkedListService.AddFirst(doublyLinkedList, new DoublyLinkedNode { Data = 10 });
        //doublyLinkedListService.AddFirst(doublyLinkedList, new DoublyLinkedNode { Data = 15 });
        //doublyLinkedListService.AddFirst(doublyLinkedList, new DoublyLinkedNode { Data = 20 });
        //doublyLinkedListService.AddLast(doublyLinkedList, new DoublyLinkedNode { Data = 25 });


        var doublyLinkedList = new DoublyLinkedList.App.Collections.DoublyLinkedList();

        doublyLinkedList.AddFirst(10);
        doublyLinkedList.AddFirst(15);
        doublyLinkedList.AddFirst(20);
        doublyLinkedList.AddLast(25);
        doublyLinkedList.Remove(15);

        foreach (var node in doublyLinkedList)
        {
            Console.Write(node.Data + " ");
        }
    }
}
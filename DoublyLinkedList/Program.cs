//using DoublyLinkedList.App.Interfaces;
//using DoublyLinkedList.App.Models;
//using Microsoft.Extensions.DependencyInjection;

using DoublyLinkedList.App.DoublyLinkedList;

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


        var doublyLinkedList = new DoubleLinkedList();

        doublyLinkedList.AddFirst(10);
        doublyLinkedList.AddFirst(15);
        doublyLinkedList.AddFirst(20);
        doublyLinkedList.AddLast(25);
        doublyLinkedList.Remove(15);
        doublyLinkedList.AddFirst(35);
        doublyLinkedList.AddLast(3);

        foreach (var node in doublyLinkedList)
        {
            Console.Write(node.Data + " ");
        }

        Console.WriteLine();

        doublyLinkedList.QuickSort();

        foreach (var node in doublyLinkedList)
        {
            Console.Write(node.Data + " ");
        }
    }
}
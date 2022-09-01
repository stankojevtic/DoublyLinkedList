using DoublyLinkedList.App.Interfaces;
using DoublyLinkedList.App.Models;
using DoublyLinkedList.App.Services;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    public static void Main(string[] args)
    {
        //setup DI
        var serviceProvider = new ServiceCollection()
            .AddTransient<IDoublyLinkedListService, DoublyLinkedListService>()
            .BuildServiceProvider();
        var doublyLinkedListService = serviceProvider.GetService<IDoublyLinkedListService>();

        var doublyLinkedList = new List<DoublyLinkedNode>();

        doublyLinkedListService.AddFirst(doublyLinkedList, new DoublyLinkedNode { Data = 10 });
        doublyLinkedListService.AddFirst(doublyLinkedList, new DoublyLinkedNode { Data = 15 });
        doublyLinkedListService.AddFirst(doublyLinkedList, new DoublyLinkedNode { Data = 20 });
        doublyLinkedListService.AddLast(doublyLinkedList, new DoublyLinkedNode { Data = 25 });
    }
}
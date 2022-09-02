using System.Xml.Linq;
using DoublyLinkedList.App.DoublyLinkedList;
using DoublyLinkedList.App.Interfaces;
using DoublyLinkedList.App.Models;
using DoublyLinkedList.App.Services;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    public static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddTransient<ISortService<Node<Size>>, QuickSortService<Size>>()
            .BuildServiceProvider();

        var sortService = serviceProvider.GetService<ISortService<Node<Size>>>();

        //Example 1
        var doublyLinkedList = new DoubleLinkedList<Size>(sortService);

        doublyLinkedList.AddFirst(new Size(10));
        doublyLinkedList.AddFirst(new Size(15));
        doublyLinkedList.AddFirst(new Size(20));
        doublyLinkedList.AddLast(new Size(25));
        doublyLinkedList.Remove(new Size(15));
        doublyLinkedList.AddFirst(new Size(35));
        doublyLinkedList.AddLast(new Size(3));

        foreach (var node in doublyLinkedList)
        {
            Console.Write(node.Data + " ");
        }

        Console.WriteLine();

        doublyLinkedList.Sort();

        foreach (var node in doublyLinkedList)
        {
            Console.Write(node.Data + " ");
        }
    }
}
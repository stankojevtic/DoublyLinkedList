using System;
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
            .AddTransient<ISortService, QuickSortService>()
            .BuildServiceProvider();

        var sortService = serviceProvider.GetService<ISortService>();

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

        Console.WriteLine();

        //Example 2
        var doublyLinkedList1 = new DoubleLinkedList<int>(sortService);

        doublyLinkedList1.AddFirst(10);
        doublyLinkedList1.AddFirst(15);
        doublyLinkedList1.AddFirst(20);
        doublyLinkedList1.AddLast(25);
        doublyLinkedList1.Remove(15);
        doublyLinkedList1.AddFirst(35);
        doublyLinkedList1.AddLast(3);

        foreach (var node in doublyLinkedList1)
        {
            Console.Write(node.Data + " ");
        }

        Console.WriteLine();

        doublyLinkedList1.Sort();

        foreach (var node in doublyLinkedList1)
        {
            Console.Write(node.Data + " ");
        }
    }
}
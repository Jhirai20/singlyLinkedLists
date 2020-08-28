using System;

namespace SinglyLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Single Linked List are Ideal for creating a que for say a playlist.
            SinglyLinkedList list=new SinglyLinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Console.WriteLine(list.Find(2).Value) ;
            list.PrintValues();
            list.Remove();
            list.PrintValues();
        }
    }
}

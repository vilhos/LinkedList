using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList<int> singleList = new SingleLinkedList<int>();

            singleList.InsertFront(5);
            singleList.InsertFront(8);
            singleList.InsertFront(12);
            singleList.InsertLast(15);
            singleList.InsertAfter(singleList.head.next, 88);
            singleList.GetLastNode();
            singleList.DeleteNodebyKey(12);
            singleList.ReverseLinkedList();

            DoubleLinkedList<string> doubleList = new DoubleLinkedList<string>();
            doubleList.InsertFront("5");
            doubleList.InsertFront("8");
            doubleList.InsertFront("12");
            doubleList.InsertLast("15");
            doubleList.InsertAfter(doubleList.head.next, "88");
            doubleList.GetLastNode();
            doubleList.DeleteNodebyKey("12");
            doubleList.ReverseLinkedList();

            Console.ReadLine();
        }
    }
}

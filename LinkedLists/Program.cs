using System;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList myLinkedList = new SingleLinkedList();
            myLinkedList.head = null;

            SinglyListOperations operations = new SinglyListOperations();

            operations.InsertFront(myLinkedList, 1);
            operations.InsertFront(myLinkedList, 2);
            operations.InsertFront(myLinkedList, 3);
            operations.InsertFront(myLinkedList, 4);
            operations.InsertFront(myLinkedList, 5);

            // operations.PrintList_R(myLinkedList.head);
            Console.WriteLine("==================\nSingly linked list\n==================\n");
            operations.PrintList_I(myLinkedList.head);
            Console.WriteLine("\n");

            Console.WriteLine("Insert 0 at the end of the list =>");
            operations.InsertEnd(myLinkedList, 0);
            operations.PrintList_I(myLinkedList.head);
            Console.WriteLine("\n");

            Console.WriteLine("Insert 67 after 0 =>");
            operations.InsertAfter(myLinkedList, 0, 67);
            operations.PrintList_I(myLinkedList.head);
            Console.WriteLine("\n");

            Console.WriteLine("Insert 29 after 2 =>");
            operations.InsertAfter(myLinkedList, 2, 29);
            operations.PrintList_I(myLinkedList.head);
            Console.WriteLine("\n");

            Node lastNode = operations.GetLastNode(myLinkedList);
            Console.Write($"Last node: {lastNode.data}");
            Console.WriteLine("\n");

            Console.WriteLine("Delete 4 from the list");
            operations.DeleteNodeByKey(myLinkedList, 4);
            operations.PrintList_I(myLinkedList.head);
            Console.WriteLine("\n");

            Console.WriteLine("Reverse the list iteratively");
            operations.ReverseLinkedList_I(myLinkedList);
            operations.PrintList_I(myLinkedList.head);
            Console.WriteLine("\n");

            Console.WriteLine("Return list by reversing recursively");
            Node reversedList =  operations.ReverseLinkedList_R(myLinkedList.head);
            operations.PrintList_I(reversedList);
            Console.WriteLine();

            DoublyLinkedList myDoublyLinkedList = new DoublyLinkedList();
            myDoublyLinkedList.head = null;
            DoublyLinkedListOperations d_operations = new DoublyLinkedListOperations();

            d_operations.InsertFront(myDoublyLinkedList, 100);
            d_operations.InsertFront(myDoublyLinkedList, 200);
            d_operations.InsertFront(myDoublyLinkedList, 300);
            d_operations.InsertFront(myDoublyLinkedList, 500);
            d_operations.InsertFront(myDoublyLinkedList, 600);

            Console.WriteLine("\n===================\nDoubly Linked List\n===================\n");
            d_operations.printDList(myDoublyLinkedList);
            Console.WriteLine("\n");

            Console.WriteLine("Insert zero at the end");
            d_operations.insertEnd(myDoublyLinkedList, 0);
            d_operations.printDList(myDoublyLinkedList);
            Console.WriteLine("\n");

            Console.WriteLine("Insert 400 after 500");
            d_operations.insertAfter(myDoublyLinkedList, 500, 400);
            d_operations.printDList(myDoublyLinkedList);
            Console.WriteLine("\n");

            Console.WriteLine("Insert 999 after 200");
            d_operations.insertAfter(myDoublyLinkedList, 200, 999);
            d_operations.printDList(myDoublyLinkedList);
            Console.WriteLine("\n");

            Console.WriteLine("Delete 999 from list");
            d_operations.deleteByKey(myDoublyLinkedList, 999);
            d_operations.printDList(myDoublyLinkedList);
            Console.WriteLine("\n");

            Console.WriteLine("Reverse list");
            myDoublyLinkedList.head =  d_operations.Reverselist(myDoublyLinkedList.head);
            d_operations.printDList(myDoublyLinkedList);
            Console.WriteLine("\n");

            Console.WriteLine("Reverse using stack");
            myDoublyLinkedList.head = d_operations.StackReverse(myDoublyLinkedList.head);
            d_operations.printDList(myDoublyLinkedList);
            Console.WriteLine("\n");
        }

    }
}

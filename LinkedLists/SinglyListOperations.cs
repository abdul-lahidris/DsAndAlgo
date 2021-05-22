using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{

    internal class Node
    {
        internal int data;
        internal Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
    internal class SingleLinkedList
    {
        internal Node head;
    }
    public class SinglyListOperations
    {
        // Insert data at the begining of the linked list
        internal void InsertFront(SingleLinkedList singlyList, int newData)
        {
            Node newNode = new Node(newData);
            newNode.next = singlyList.head;
            singlyList.head = newNode;
        }

        // Insert data at the end of a linked list
        internal void InsertEnd(SingleLinkedList singlyList, int newData)
        {
            Node newNode = new Node(newData);
            if (singlyList.head == null)
            {
                newNode.next = singlyList.head;
                return;
            }
            Node lastNode = GetLastNode(singlyList);
            lastNode.next = newNode;
        }

        // Insert node at nth position
        internal void InsertAfter(SingleLinkedList singlyList, int previousNodeData, int newData)
        {
            Node newNode = new Node(newData);
            Node temp = singlyList.head;
            while (previousNodeData != temp.data)
            {
                temp = temp.next;
            }
            //if (previousNodeData == null)
            //    Console.WriteLine("The given previous node cannot be null");
            newNode.next = temp.next;
            temp.next = newNode;
        }

        // Delete a Node by keyword
        internal void DeleteNodeByKey(SingleLinkedList singlyList, int key)
        {
            Node temp = singlyList.head;
            Node prevNode = null;
            if (prevNode == null && temp != null && temp.data == key) //if it's first node
            {
                singlyList.head = temp.next;
                return;
            }
            while (temp != null && temp.data != key)
            {
                prevNode = temp;
                temp = temp.next;
            }

            if (prevNode != null && temp != null && temp.data == key) //at the centre of last
            {
                prevNode.next = temp.next;
                return;
            }
            if (temp == null)
                return;
        }

        // Reversing a linked list Iteratively
        internal void ReverseLinkedList_I(SingleLinkedList singlyList)
        {
            Node temp = null;
            Node prevNode = null;
            Node currentNode = singlyList.head;
            while (currentNode != null)
            {
                temp = currentNode.next;
                currentNode.next = prevNode;
                prevNode = currentNode;
                currentNode = temp;
            }
            singlyList.head = prevNode;
        }

        // Reversing a linked list Recursively
        internal Node ReverseLinkedList_R(Node head)
        {
            if (head == null)
                return head;
            // Single
            if (head.next == null)
                return head;
            Node newHead = ReverseLinkedList_R(head.next);
            head.next.next = head;
            head.next = null;

            return newHead;

        }


        // Get last node
        internal Node GetLastNode(SingleLinkedList singlyList)
        {
            Node temp = singlyList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        // Print a linked list by iteration
        internal void PrintList_I(Node head)
        {
            Node temp = head;
            while (head.next != null)
            {
                Console.Write($"{temp.data} ");
                if (temp.next == null)
                    break;
                temp = temp.next;
            }
           
        }

        // Print a linked list by recursion
        internal void PrintList_R(Node head)
        {
            if (head.next == null)
            {
                Console.Write($"{head.data} ");
                return;
            } 
            Console.Write($"{head.data} ");
            PrintList_I(head.next);
        }
    }
}

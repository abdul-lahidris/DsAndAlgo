using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    internal class DNode
    {
        internal int data;
        internal DNode next;
        internal DNode prev;
        public DNode(int d)
        {
            data = d;
            next = null;
            prev = null;
        }
    }

    internal class DoublyLinkedList
    {
        internal DNode head;
    }
    class DoublyLinkedListOperations
    {
        internal void InsertFront(DoublyLinkedList doublyLinkedList, int newData)
        {
            DNode newNode = new DNode(newData);
            newNode.next = doublyLinkedList.head;
            newNode.prev = null;
            if (doublyLinkedList.head != null)
                doublyLinkedList.head.prev = newNode;
            doublyLinkedList.head = newNode;
        }

        internal void insertEnd(DoublyLinkedList doublyLinkedList, int newData)
        {
            DNode newNode = new DNode(newData);
            if (doublyLinkedList.head == null)
            {
                newNode.prev = null;
                doublyLinkedList.head = newNode;
                return;
            }
            DNode lastNode = GetLastNode(doublyLinkedList);
            lastNode.next = newNode;
            newNode.prev = lastNode;

        }

        // Delete by key
        internal void deleteByKey(DoublyLinkedList doublyLinkedList, int key)
        {
            DNode temp = doublyLinkedList.head;
            if (temp.prev != null && temp.next != null && temp.data == key) // at the begining
            {
                doublyLinkedList.head = temp.next;
                doublyLinkedList.head.prev = null;
                return;
            }
            while (temp.next != null && temp.data != key)
            {
                temp = temp.next;
            }
            if (temp.prev != null & temp.next != null && temp.data == key) // Previous Node
            {
                DNode prevNode = temp.prev;
                prevNode.next = temp.next;
                temp.next.prev = prevNode;
                return;
            }
            if (temp.prev != null & temp.next == null && temp.data == key) // Last node
            {
                DNode prevNode = temp.prev;
                prevNode.next = null;
                return;
            }
            if (temp == null)
                return;

        }

        // Insert after a key
        internal void insertAfter(DoublyLinkedList doublyLinkedList, int key, int newData)
        {
            DNode newNode = new DNode(newData);
            DNode temp = doublyLinkedList.head;
            if (temp != null)
            {
                while (temp.next != null && temp.data != key)
                {
                    temp = temp.next;
                }
                if (temp.next == null)
                {
                    temp.next = newNode;
                    newNode.prev = temp;
                    newNode.next = null;
                }
                if (temp.next != null)
                {
                    newNode.next = temp.next;
                    temp.next = newNode;
                    newNode.prev = temp;
                    newNode.next.prev = newNode;
                }

            }
        }

        // Reverse Doubly linked list
        internal DNode Reverselist(DNode head)
        {
            
            if (head == null)
            {
                return head;
            }
            if (head.next == null)
            {
                head.prev = null;
                return head;
            }
            DNode newHead = Reverselist(head.next);
            head.next.next = head;
            head.prev = head.next;
            head.next = null;

            return newHead;
        }

        //reverse using stack
        internal DNode StackReverse(DNode head)
        {
            Stack<DNode> headStack = new Stack<DNode>();
            Stack<DNode> prevStack = new Stack<DNode>();
            while (head != null)
            {
                headStack.Push(head);
                if (head.prev != null)
                    prevStack.Push(head.prev);
                head = head.next;
            }
            prevStack.Push(headStack.Peek());
            DNode newHead = headStack.Peek();
            headStack.Pop();
            newHead.next = headStack.Peek();
            newHead.prev = null;
            //prevStack.Pop();
            while (headStack.Count > 1)
            {
                head = headStack.Peek();
                headStack.Pop();
                head.next = headStack.Peek();
                head.prev = prevStack.Peek();
                prevStack.Pop();
            }
            head = headStack.Peek();
            headStack.Pop();
            head.next = null;
            head.prev = prevStack.Peek();
            prevStack.Clear();
            return newHead;
        }

        // Print doubly linked list
        internal void printDList(DoublyLinkedList doublyLinkedList)
        {
            
            DNode temp = doublyLinkedList.head;
            while(temp != null)
            {
                Console.Write($"{temp.data} ");
                temp = temp.next;
            }
        }

        // Get last node
        internal DNode GetLastNode(DoublyLinkedList doublyList)
        {
            DNode temp = doublyList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }


    }
}

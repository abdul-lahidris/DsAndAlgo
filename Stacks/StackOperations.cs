using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks
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
        public Node(char d)
        {
            data = d;
            next = null;
        }
    }
    internal class Stack
    {
        internal Node top;
    }
    class StackOperations
    {
        internal void push(Stack myStack, int data)
        {
            Node newNode = new Node(data);
            newNode.next = myStack.top;
            myStack.top = newNode;
        }

        internal void pop(Stack myStack)
        {
            Node temp = myStack.top;
            if (temp == null)
                return;  
            myStack.top = temp.next;
            temp.next = null;
        }

        internal void printStack(Stack myStack)
        {
            Node temp = myStack.top;
            while (temp != null)
            {
                Console.Write($"{temp.data} ");
                if (temp.next == null)
                    return;
                temp = temp.next;
            }
        }

    }

}

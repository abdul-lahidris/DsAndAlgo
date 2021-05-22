using System;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Stacks!");
            Stack myStack = new Stack();
            myStack.top = null;

            StackOperations operations = new StackOperations();

            operations.push(myStack, 1);
            operations.push(myStack, 2);
            operations.push(myStack, 3);
            operations.push(myStack, 4);
            operations.push(myStack, 5);

            operations.printStack(myStack);

            Console.WriteLine("\n\nPop stack");
            operations.pop(myStack);
            operations.printStack(myStack);
            Console.WriteLine("\n\nPop stack again");
            operations.pop(myStack);
            operations.printStack(myStack);
            Console.WriteLine("\n\nPush 23 to stack");
            operations.push(myStack, 23);
            operations.printStack(myStack);

        }
    }
}

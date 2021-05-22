using System;
using System.Collections.Generic;
using System.Text;

namespace QueuesArrAndLL
{
    internal class QueueObj
    {
        internal int?[] data;
        internal int front;
        internal int rear;
        public QueueObj(int?[] d)
        {
            data = d;
            front = 0;
            rear = 0;
        }
    }
    class ArrQueues
    {
        internal QueueObj CreateQueue(int size)
        {
            int?[] newQueue = new int?[size];
            QueueObj myQueue = new QueueObj(newQueue);
            return myQueue;
        }
        internal void Enqueue(QueueObj queueObj, int input)
        {
            if (IsFull(queueObj))
            {
                Console.WriteLine($"Oops! Queue is full: cannot enqueue {input}");
                return;
            }
            Console.WriteLine($"Enquque: {input}");
            if (IsEmpty(queueObj))
                queueObj.data[queueObj.rear] = input;
            else
            {
                int next = (queueObj.rear + 1) % queueObj.data.Length;
                queueObj.data[next] = input;
                queueObj.rear = next;
            }  
        }
        internal int? Dequeue(QueueObj queueObj)
        {
            if (IsEmpty(queueObj))
            {
                Console.WriteLine("Queue is empty");
                return null;
            }
            int newfront = (queueObj.front + 1 + queueObj.data.Length) % queueObj.data.Length;
            int? output = queueObj.data[queueObj.front];
            queueObj.data[queueObj.front] = null;
            queueObj.front = newfront;
            return output;
        }

        internal void PrintQueue(QueueObj queueObj)
        {
            if (IsEmpty(queueObj))
                Console.WriteLine("Queue is empty");
            else
            {
                Console.Write($"Queue: {queueObj.data[queueObj.front]} ");
                int next = (queueObj.front + 1) % queueObj.data.Length;
                if(queueObj.front < queueObj.rear)
                {
                    while (queueObj.rear >= next)
                    {
                        if (queueObj.data[next] == null)
                            break;
                        if (queueObj.data[next] != null)
                            Console.Write($"{queueObj.data[next]} ");
                        next = (next + 1) % queueObj.data.Length;
                    }
                }
                if (queueObj.front > queueObj.rear)
                {
                    while (next != queueObj.rear)
                    {
                        if (queueObj.data[next] == null)
                            break;
                        if (queueObj.data[next] != null)
                            Console.Write($"{queueObj.data[next]} ");
                        next = (next + 1) % queueObj.data.Length;
                    }
                    Console.Write($"{queueObj.data[next]}");
                }
                
                Console.WriteLine();
            }
        }

        internal bool IsFull(QueueObj queueObj)
        {
            if ((queueObj.rear + 1) % queueObj.data.Length == queueObj.front)
                return true;
            else 
                return false;
        }
        internal bool IsEmpty(QueueObj queueObj)
        {
            if ((queueObj.front + queueObj.rear) == 0 && queueObj.data[0] == null)
                return true;
            else
                return false;
        }
    }
}

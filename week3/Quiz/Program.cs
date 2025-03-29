using System;
using System.Collections;
using System.Collections.Generic;

namespace Quiz
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("문제 1)");
            quiz1();
            Console.WriteLine("문제 2)");
            quiz2();
        }
        public static void quiz1()
        {
            //ArrayList arr;
            ArrayList arr = new ArrayList();
            for(int i = 0;i<=10;i++)
            {
                //arr[i] = i;
                arr.Add(i);
                Console.WriteLine("nums : " + arr[i]);
            }
        }
        public static void quiz2()
        {
            Stack<int> stack = new Stack<int>();
            Queue<int> queue = new Queue<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);

            queue.Enqueue(stack.Pop());
            stack.Push(queue.Dequeue());

            Console.WriteLine(stack.Pop());
            Console.WriteLine(queue.Dequeue());
        }
    }
}
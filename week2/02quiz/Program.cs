using System;

namespace _02quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(1,2));
            Console.WriteLine(Sum(1,2,3));
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}

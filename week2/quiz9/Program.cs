using System;

namespace quiz9
{
    class Program
    {
        static void Main()
        {
            method1("1", "2");
            method2("2", "1");
            
        }
        void method1(string str1, string str2, int num1 = 0)
        {
            Console.WriteLine($"{str1} {str2} {num1}");
        }
        void method2(string str1, int num1 = 0, string str2 = "null")
        {
            Console.WriteLine($"{str1} {str2} {num1}");
        }
    }
}

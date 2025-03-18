using System;

namespace method_overload
{
    class Program
    {
        static void Main()
        {
			Console.WriteLine(Sum(1,2));
			Console.WriteLine(Sum(1.1f, 3.3f));
        }
		public static int Sum(int a, int b)
		{
			return a + b;
		}
		public static float Sum(float a, float b)
		{
			return a + b;
		}
    }
}

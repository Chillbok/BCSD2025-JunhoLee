using System;
using System.Collections;

namespace StackPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //컬렉션 자료구조는 선언한 변수에 new로 메모리를 할당해야 사용할 수 있다.
            Stack stack01 = new Stack();

            //스택의 최상위에 새로운 요소 추가
            stack01.Push("문자열");
            for (int i = 0; i < 3; i++)
            {
                stack01.Push(i);
            }

            Console.WriteLine($"최상위 요소 삭제하지 않고 반환: {stack01.Peek()}");
            PrintLine();
            Console.WriteLine($"최상위 요소 삭제하고 반환: {stack01.Pop()}");
            Console.WriteLine($"삭제 뒤 다음 요소 삭제하지 않고 반환: {stack01.Peek()}");
            PrintLine();
            stack01.Clear();
            Console.WriteLine($"스택 모든 요소 삭제 완료: {stack01.Count}")
        }

        public static void PrintLine()
        {
            Console.WriteLine("====================");
        }
    }
}
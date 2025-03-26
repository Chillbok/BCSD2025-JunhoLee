using System;
using System.Collection;

namespace CollectionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ArrayList 연습
            */
            Console.WriteLine("Hello World!");
            //컬렉션 자료구조는 선언한 변수에 메모리를 할당해야 사용할 수 있다.
            ArrayList array = new ArrayList();
            array.Add(10);

            //요소에 접근할 때는 첨자 연산자 []를 이용한다.
            Console.WriteLine(array[0]);
        }
    }
}

using System;
using System.Collections;

namespace QueuePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //컬렉션 자료구조는 선언한 변수에 new로 메모리를 할당해야 사용할 수 있다.
            Queue queue1 = new Queue();

            queue1.Enqueue("문자열 요소");

            //후단에 새로운 요소 추가
            for (int i = 0; i < 2; i++)
            {
                queue1.Enqueue(i);  // 콜렉션이므로 다른 타입의 요소도 추가할 수 있다.
            }

            //현재 큐에 저장된 요소의 개수
            Console.WriteLine($"queue1 요소 개수: {queue1.Count}");

            //전단에 있는 요소를 삭제하지 않고, 요소를 반환할 때 사용
            PrintLine();
            Console.WriteLine($"전단 요소 삭제 없이 확인만: {queue1.Peek()}");

            //전단에 있는 요소를 삭제하고, 삭제한 요소를 반환
            PrintLine();
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine($"전단에 있는 요소 삭제하고, 삭제한 요소 반환({i}): {queue1.Dequeue()}"); //전단 두 번 삭제
            }
            Console.WriteLine($"요소들 삭제된 후 현재 전단: {queue1.Peek()}");

            //큐의 모든 요소 삭제
            queue1.Clear();
            PrintLine();
            Console.WriteLine($"큐 모든 요소 삭제 후 전단: {queue1.Peek()}");   //출력되지 않는다. 에러가 나온다.
        }

        public static void PrintLine()
        {
            Console.WriteLine("====================");
        }
    }
}

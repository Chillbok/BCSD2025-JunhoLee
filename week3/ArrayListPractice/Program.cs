using System;
using System.Collections;

namespace CollectionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ArrayList 연습
            */
            //컬렉션 자료구조는 선언한 변수에 메모리를 할당해야 사용할 수 있다.
            ArrayList array = new ArrayList();
            
            // 마지막 요소 뒤에 새로운 요소 추가
            array.Add(10);  // 이 경우에는 array[0] = 10;과 같음
            Console.WriteLine("array[0] 출력:");
            Console.WriteLine($"\tarray[0]: {array[0]}");    // 10 출력

            // 맨 마지막에 다른 타입의 새로운 요소 추가
            // ArrayList는 배열과 다르게 자유롭게 다양한 타입의 변수를 추가할 수 있다.
            array.Add("이준호");    //array에 string 요소 맨 뒤에 추가

            //array 모든 항목 출력
            PrintArrayList(array);

            //array 특정 위치의 요소 다른 것으로 바꾸기
            array.Insert(0,1.5f);   // array[0]을 10에서 1.5f로 바꾸기
            PrintArrayList(array);

            //array에서 특정 내용의 요소 삭제하는 법
            array.Add("삭제용");
            Console.WriteLine("> array에 삭제용 요소 추가");
            PrintArrayList(array);
            array.Remove("삭제용");
            Console.WriteLine("> array에서 삭제용 요소 삭제");
            PrintArrayList(array);

            //array에서 특정 위치의 요소 삭제하는 법
            array.Add("삭제용");
            Console.WriteLine("> array에 삭제용 요소 추가");
            PrintArrayList(array);

            array.RemoveAt(3);
            Console.WriteLine("> array에서 삭제용 요소 삭제");
            PrintArrayList(array);

            //array에서 특정 범위의 요소 삭제하는 법
            array.Add("삭제용1");
            array.Add("삭제용2");
            Console.WriteLine("> array에서 삭제용 요소 2개 추가");
            PrintArrayList(array);
            array.RemoveRange(3,2); //array[3]부터 2개 요소 삭제
            Console.WriteLine("> array에서 요소 2개 삭제");
            PrintArrayList(array);

            //array 모든 요소 삭제해서 초기화하는 법
            array.Clear();
            Console.WriteLine("> array 초기화");
            PrintArrayList(array);

            //array 요소들 오름차순으로 정렬하는 법
            //정수 한정으로 사용 가능하며, 요소 중에 정수가 아닌 데이터가 있으면 에러가 발생한다.
            array.Add(1);
            array.Add(10);
            array.Add(5);
            array.Add(4);
            array.Add(7);

            Console.WriteLine("> array에 무작위 5개 정수 추가");
            PrintArrayList(array);  //정렬되지 않은 array 그대로 출력
            array.Sort();   //array 정렬
            Console.WriteLine("> array 정렬 완료");
            PrintArrayList(array);  //정렬된 array 출력

            //array 요소 개수 세는 법
            Console.WriteLine("> array 개수 세는 법");
            Console.WriteLine($"\tarray 개수: {array.Count}");
        }

        public static void PrintArrayList(ArrayList list)
        {
            Console.WriteLine("=========================");
            Console.WriteLine("array:");
            
            //ArrayList에서 Count 사용법
            for(int i = 0; i < list.Count; i++) //매개변수 arraylist의 개수만큼 반복
            {
                Console.WriteLine($"\tarray[{i}]: {list[i]}");
            }
            Console.WriteLine("=========================");
        }
    }
}

using System;

namespace 자료구조
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            리스트 실습
            ====================================
            */
            MakeArray arrayItems = new MakeArray();
            
            //정수 배열 생성
            int[] numbers = new int[5];
            arrayItems.ResetNumbers(numbers);
            arrayItems.PrintItems(numbers);

            //문자열 배열 생성
            string[] names = {"이준호", "김철수", "김영희"};
            arrayItems.PrintItems(names);

            /*
            Linked List 실습
            ====================================
            */
        }
    }

    class MakeArray
    {
        //배열 초기화 메소드
        public void ResetNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }
        }

        //정수 배열 출력 메소드
        public void PrintItems(int[] x)
        {
            Console.WriteLine("정수 배열:");
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
        }

        //문자열 배열 출력 메소드
        public void PrintItems(string[] x)
        {
            Console.WriteLine("문자열 배열:");
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
        }
    }
}
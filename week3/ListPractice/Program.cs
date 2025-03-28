using System;
using System.Collections;
using System.Collections.Generic;

namespace ListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();    //정수 리스트 생성
            List<string> names = new List<string>();    //문자열 리스트 생성

            //int형 요소 추가
            for(int i = 0;i<3;i++)
            {
                numbers.Add(i*10);
            }

            //문자열 list에 요소 추가
            names.Add("이준호1");
            names.Add("이준호2");
            names.Add("이준호3");

            //변수에 특정 요소 대입
            PrintLine();
            int firstnumber = numbers[0];
            string firstname = names[0];
            Console.WriteLine("변수에 list의 특정 요소 대입:");
            Console.WriteLine($"\tfirstnumber = {firstnumber}");
            Console.WriteLine($"\tfirstname = {firstname}");

            //리스트에 특정 인덱스에 특정 요소 삽입 또는 삭제
            PrintLine();
            Console.WriteLine("리스트 특정 인덱스에 특정 요소 삽입 또는 삭제:");
            Console.WriteLine("현재 리스트:");
            ListStatus(names);  //확인용 리스트 출력

            PrintLine();
            Console.WriteLine("삽입 후 리스트:");
            names.Insert(1,"삽입됨");
            ListStatus(names);  //확인용 리스트 출력

            //리스트 특정 요소 삭제
            PrintLine();
            Console.WriteLine("삽입한 요소 삭제(Remove) 후 리스트:");
            names.Remove("삽입됨");
            ListStatus(names);

            PrintLine();
            Console.WriteLine("요소 추가 후 리스트:");
            names.Insert(1,"삽입됨2");
            ListStatus(names);

            PrintLine();
            Console.WriteLine("삽입한 요소 삭제(RemoveAt) 후 리스트:");
            names.RemoveAt(1);
            ListStatus(names);

            //리스트 특정 요소가 존재하는지 확인
            PrintLine();
            Console.WriteLine("리스트 특정 요소가 존재하는지 확인");
            Console.WriteLine("리스트 내용:");
            ListStatus(names);
            Console.WriteLine($"요소 \"이준호1\" 있는지 확인: {names.Contains("이준호1")}");
            Console.WriteLine($"요소 \"ㅇㅇ\"있는지 확인: {names.Contains("ㅇㅇ")}");
            Console.WriteLine($"요소 \"이준호\"의 인덱스: {names.IndexOf("이준호1")}");

            //무작위로 섞인 정수 리스트 나열하기
            PrintLine();
            List<int> needSort = new List<int>() {4, 23, 1, 10};
            Console.WriteLine("현재 리스트:");
            ListStatus(needSort);
            needSort.Sort();
            PrintLine();
            Console.WriteLine("정렬한 리스트");
            ListStatus(needSort);

            //리스트 내용 초기화
            PrintLine();
            Console.WriteLine("리스트 내용 지우기");
            Console.WriteLine("리스트 현재 내용:");
            ListStatus(needSort);
            PrintLine();
            Console.WriteLine("리스트 지운 후 내용:");
            needSort.Clear();
            ListStatus(needSort);
        }
        public static void PrintLine()
        {
            Console.WriteLine("====================");
        }
        public static void ListStatus(List<int> list)
        {
            foreach(int item in list)
            {
                Console.WriteLine($"\t{item}");
            }
        }

        public static void ListStatus(List<string> list)
        {
            foreach(string item in list)
            {
                Console.WriteLine($"\t{item}");
            }
        }
    }
}
/*
numbers.Remove(10);     //값으로 삭제
Console.WriteLine($"값 삭제 후 출력: {numbers[0]}");
names.RemoveAt(0);      //인덱스로 삭제
names.Insert(0,"이준호1");
names.Contains("이준호1");
names.IndexOf("이준호1");
numbers.Clear();

PrintLine();
List<int> needSort = new List<int> {4, 2, 7, 5};
Console.WriteLine($"무작위 정수가 적혀진 list:");

int i = 0;
foreach (int num in needSort)
{
    Console.WriteLine($"\tneedSort[{i}]: {num}");
    i++
}
*/
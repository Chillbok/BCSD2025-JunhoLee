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
            firstnumber = numbers[0];
            firstname = names[0];
            Console.WriteLine("변수에 list의 특정 요소 대입:");
            Console.WriteLine($"\tfirstnumber = {firstnumber}");
            Console.WriteLine($"\tfirstname = {firstname}");

            //리스트 내용 삭제
            PrintLine();
            Console.WriteLine("현재 리스트:");
            ListStatus(numbers);
            numbers.Remove(20);
            Console.WriteLine("요소 \"20\" 지운 후 리스트:");
            ListStatus(numbers);
            

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

numbers.Remove(10);     //값으로 삭제
Console.WriteLine($"값 삭제 후 출력: {numbers[0]}");
names.RemoveAt(0);      //인덱스로 삭제
names.Insert(0,"이준호1");
names.Contains("이준호1");
names.IndexOf("이준호1");
numbers.Clear();

PrintLine();
List<int> needSort = new List<int> {4, 2, 7, 5};
Console.WriteLine($"무작위 정수가 적혀진 list:")

int i = 0;
foreach (int num in needSort)
{
    Console.WriteLine($"\tneedSort[{i}]: {num}");
    i++
}
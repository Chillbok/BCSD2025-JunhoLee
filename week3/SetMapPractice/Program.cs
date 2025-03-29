using System;
using System.Collections;
using System.Collections.Generic;

namespace SetMapPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Set 실습
            HashSet<string> names = new HashSet<string>();
            names.Add("이준호1");
            names.Add("이준호2");
            names.Add("이준호3");
            names.Add("이준호4");

            PrintLine();
            Console.WriteLine("Set 각 요소 출력");
            PrintSet(names);

            //Remove
            PrintLine();
            names.Remove("이준호3");
            Console.WriteLine("\"이준호3\" 삭제함:");
            PrintSet(names);

            //Contains
            PrintLine();
            Console.WriteLine("Set에 특정 요소가 포함되어 있는지 확인인")
            Console.WriteLine($"\"이준호3\"을 포함하는가?: {names.Contains("이준호3")}");   //참
            Console.WriteLine($"\"이준호4\"을 포함하는가?: {names.Contains("이준호4")}");   //거짓

            //Map 실습
            Dictionary<string,int> scores = new Dictionary<string,int>();
            scores.Add("이준호", 100);
            scores.Add("김철수", 80);
            scores.Add("박영희", 90);

            PrintLine();
            Console.WriteLine($"이준호 성적: {scores["이준호"]}");
        }

        public static void PrintLine()
        {
            Console.WriteLine("========================================");
        }
        public static void PrintSet(HashSet<string> hashset)
        {
            foreach (string item in hashset)
            {
                Console.WriteLine($"\t{item}");
            }
        }
    }
}
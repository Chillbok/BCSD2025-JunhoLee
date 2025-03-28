using System;
using System.Collections;

namespace HashtablePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hash = new Hashtable();

            //요소 추가
            //컬렉션 자료구조는 object 타입을 저장하기 때문에 클래스 인스턴스도 저장 가능하다
            Goblin goblin = new Goblin();
            Slime slime = new Slime();

            //요소 추가( [] 연산자)
            hash["Goblin"] = goblin;

            //요소 추가(Add)
            hash.Add("Slime", slime);
            hash.Add(1, "정수");
            hash.Add(1.2f, "실수");
            hash.Add("안녕하세요. 이준호입니다.", "문자열")

            //
            

        }

        public static void PrintLine()
        {
            Console.WriteLine("=========================");
        }

        public static void PrintHashtable(Hashtable x)
        {
            foreach(object key in x.Keys)
            {
                Console.WriteLine($"hash[{key}] = {hash[key]}");
            }
        }
    }

    class Goblin()
    {

    }

    class Slime()
    {

    }
}
foreach (var arr in array);
{
    Console.WriteLine(arr);
}

Hashtable hash = new Hashtable();
foreach(var key in hash.Keys)
{
    Console.WriteLine($"key: {key}, Value: {hash[key]}");
}
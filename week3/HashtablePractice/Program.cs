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
            hash.Add("class", slime);
            hash.Add("정수", 10);
            hash.Add("실수", 1.2f);
            hash.Add("문자열", "안녕하세요 이준호입니다");
            Console.WriteLine("요소 추가 후 리스트:");
            PrintHashtable(hash);

            //요소 삭제
            hash.Add("삭제용 키", "삭제용 값");
            PrintLine();
            Console.WriteLine("삭제할 요소 추가 후 내용:");
            PrintHashtable(hash);
            PrintLine();
            Console.WriteLine("요소 삭제 후 내용:");

            //키, 값 확인
            Console.WriteLine($"\t\"삭제용 키\"가 key인 요소 있는지 확인: {hash.ContainsKey("삭제용 키")}");
            Console.WriteLine($"\t\"삭제용 값\"이 value인 요소 있는지 확인: {hash.ContainsValue("삭제용 값")}");
            hash.Remove("삭제용 키");
            PrintHashtable(hash);
            hash.Remove("삭제용 키");

            //요소 개수 확인
            PrintLine();
            Console.WriteLine($"\"hash\" 해시테이블의 키 개수: {hash.Count}");
            Console.WriteLine("\"hash\" 해시테이블의 키:");
            foreach(string key in hash.Keys)
            {
                Console.WriteLine($"\t{key}");
            }

            //해시테이블 초기화
            PrintLine();
            Console.WriteLine($"해시테이블 초기화 후 해시테이블 요소:");
            PrintHashtable(hash);
            Console.WriteLine($"해시테이블 초기화 후 해시테이블 요소 개수: {hash.Count}");
        }

        public static void PrintLine()
        {
            Console.WriteLine("=========================");
        }

        public static void PrintHashtable(Hashtable x)
        {
            foreach(object key in x.Keys)
            {
                Console.WriteLine($"\tx[{key}] = {x[key]}");
            }
        }
    }

    class Goblin
    {

    }

    class Slime
    {

    }
}
/*
foreach (var arr in array);
{
    Console.WriteLine(arr);
}

Hashtable hash = new Hashtable();
foreach(var key in hash.Keys)
{
    Console.WriteLine($"key: {key}, Value: {hash[key]}");
}
*/
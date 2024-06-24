using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // 코딩 규칙 1. 변수 명은 의미 있게 지어야 한다!
            int appleCnt = 10;
            int orangeCnt = 20;

            Console.WriteLine($"{appleCnt} + {orangeCnt} = {appleCnt + orangeCnt}");
            Console.WriteLine($"{appleCnt} - {orangeCnt} = {appleCnt - orangeCnt}");
            Console.WriteLine($"{appleCnt} * {orangeCnt} = {appleCnt * orangeCnt}");
            Console.WriteLine($"{appleCnt} / {orangeCnt} = {(double)appleCnt / orangeCnt}");

            // 코딩 규칙 2. constant는 대문자로 구성한다!
            const float PI = 3.14f;
            Console.WriteLine(PI);
        }
    }
}
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

            appleCnt += 20;
            orangeCnt -= 10;
            Console.WriteLine($"apple: {appleCnt} orange: {orangeCnt}");

            // 코딩 규칙 2. constant는 대문자로 구성한다!
            const float PI = 3.14f;
            Console.WriteLine(PI);

            // 코딩 규칙 3. 변수는 소문자 두 단어 이상이면 단어 첫 부분을 대문자 appleCnt
            // 코딩 규칙 4. 상수는 모두 대문자. 두 단어 이상이면 _로 구문 APPLE_CNT
        }
    }
}
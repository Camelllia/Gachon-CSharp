using System;

namespace _2022_Gachon_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Random 객체 생성
            Random random = new Random();

            // 무작위 난수 생성
            Console.WriteLine(random.Next());

            // 범위 지정하기 - 매개 변수 1개일때 => 0 ~ A
            Console.WriteLine(random.Next(5));

            // 범위 지정하기 - 매개 변수 2개일때 => A ~ B
            Console.WriteLine(random.Next(1, 10));
        }
    }
}

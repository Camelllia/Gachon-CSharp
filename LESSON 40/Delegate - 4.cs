using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace _2022_Gachon_CSharp
{
    class Program
    {
        // 매개변수도 전달 가능
        delegate void hello();

        static void Main(string[] args)
        {
            // 함수 포인터 == 대리자
            hello say = delegate { Write("Hello"); };

            say();
            // 실행결과 => Hello
        }
    }
}

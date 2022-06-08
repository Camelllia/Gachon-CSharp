using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace _2022_Gachon_CSharp
{
    class Program
    {
        delegate void Hi();

        static void Main(string[] args)
        {
            // 괄호를 이용한 Lamda 여러 줄 처리
            Hi hi = () =>
            {
                WriteLine("hi");
                WriteLine("hi");
            };

            hi();
            // 실행 결과 => 
            // hi
            // hi
        }
    }
}

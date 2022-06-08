using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace _2022_Gachon_CSharp
{
    class Program
    {
        delegate int lamda(int n);

        static void Main(string[] args)
        {
            // Delegate + Lamda
            lamda square = x => x * x;

            Write(square(3));
            // 실행 결과 => 9

            Write(square(4));
            // 실행 결과 => 16
        }
    }
}

using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace _2022_Gachon_CSharp
{
    class Program
    {
        delegate double powDel(double a, double b);

        static void Main(string[] args)
        {
            powDel pow = Math.Pow;

            Write(pow(2, 3));
            // 실행 결과 => 8
        }
    }
}

using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace _2022_Gachon_CSharp
{
    class Program
    {
        static double getArea(int r) => 3.14 * r * r;

        // 매개변수도 전달 가능
        delegate double getAreaDelegate(int r);

        static void Main(string[] args)
        {
            getAreaDelegate area = getArea;

            Write(area(1));
            // 실행결과 => 1
        }
    }
}

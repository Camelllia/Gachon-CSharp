using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace _2022_Gachon_CSharp
{
    class Program
    {
        static void hi() => WriteLine("hi!");

        delegate void sayDelegate();

        static void Main(string[] args)
        {
            sayDelegate say = hi;
            say();
            var hy = new sayDelegate(hi);
            hy();
            // 실행 결과
            // hi!
            // hi!
        }
    }
}

using System;
using static System.Console;

namespace _2022_Gachon_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 2, 1, 4, 5 };
            // Collection - 내림차순 정렬
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Write(arr[i] + " ");
            }
        }
    }
}

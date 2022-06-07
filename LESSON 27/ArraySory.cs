using System;
using static System.Console;

namespace _2022_Gachon_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 2, 1, 4, 5 };
            // Collection - 오름차순 정렬
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Write(arr[i] + " ");
            }
        }
    }
}

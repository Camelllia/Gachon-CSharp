using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace _2022_Gachon_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3 };
            int sums = nums.Sum();
            int cnt = nums.Count();
            double avg = nums.Average();
            int maxi = nums.Max();
            int mini = nums.Min();

            Write(sums + " " + cnt + " " + avg + " " + maxi + " " + mini);
        }
    }
}

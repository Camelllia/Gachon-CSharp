using System;

namespace _2022_Gachon_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Random 객체 생성
            Random random = new Random();

            int[] arr = new int[6];

            for (int i = 0; i < 6; i++)
            {
                int temp = random.Next(1, 45);
                bool flag = false;

                for (int j = 0; j <= i; j++)
                {
                    if (arr[j] == temp)
                    {
                        flag = true;
                    }
                }

                if (flag)
                {
                    i--;
                }
                else
                {
                    arr[i] = temp;
                }
            }

            for (int i = 0; i < 6; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}

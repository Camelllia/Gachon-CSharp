using System;
using static System.Console;
using System.Collections;

namespace _2022_Gachon_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();

            hashtable["1"] = 1;
            hashtable[1] = "1";

            foreach (Object o in hashtable.Keys)
            {
                Write(hashtable[o] + " ");
            }
        }
    }
}

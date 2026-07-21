using System;
using System.Collections.Generic;
using System.Text;

namespace p2
{
    internal class p2
    {
        public static void Main()
        {
            int n = 10; // Number of terms
            int a = 0, b = 1, c;

            Console.WriteLine("Fibonacci Series:");

            for (int i = 1; i <= n; i++)
            {
                Console.Write(a + " ");

                c = a + b;
                a = b;
                b = c;
            }
        }
    }
}


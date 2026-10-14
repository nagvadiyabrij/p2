using System;
using System.Collections.Generic;
using System.Text;

namespace p2
{
    internal class array1
    {
        public static void array2()
        {
            int N;
            Console.WriteLine("enter  numbers : ");
            N = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[N];

            int positive = 0;
            int negative = 0;
            int zero = 0;

            Console.Write("Enter no. of element: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter number i: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num > 0)
                    positive++;
                else if (num < 0)
                    negative++;
                else
                    zero++;
            }

            Console.WriteLine("Positive numbers: " + positive);
            Console.WriteLine("Negative numbers: " + negative);
            Console.WriteLine("Zero numbers: " + zero);
        }
    }
}
        
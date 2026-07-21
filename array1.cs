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

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("enter element : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());

                int odd = 0;
                int even = 0;
                int count = 0;

                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine("even");
                }
                else
                { 
                    Console.WriteLine("odd");
               }

            }
        }
    }
}

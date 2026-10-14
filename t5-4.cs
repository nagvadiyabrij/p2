using System;
using System.Collections.Generic;
using System.Text;

namespace p2
{
    internal class t5_4
    {
        class Program
        {
            static void Main()
            {
                Console.WriteLine("Brij Nagvadiya\n24SOECE11024");

                Console.Write("Enter the number of elements: ");
                int n = Convert.ToInt32(Console.ReadLine());

                int[] arr1 = new int[n]; int[] arr2 = new int[n];

                Console.WriteLine("Enter " + n + " elements:");

                for (int i = 0; i < n; i++)
                {
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i < n; i++)
                {
                    arr2[i] = arr1[i];
                }

                Console.WriteLine("\nElements of the copied array:");

                for (int i = 0; i < n; i++)
                {
                    Console.Write(arr2[i] + " ");
                }
            }
        }

    }
}

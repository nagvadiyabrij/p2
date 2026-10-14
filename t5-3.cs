using System;
using System.Collections.Generic;
using System.Text;

namespace p2
{
    internal class t5_3
    {
        class Program
        {
            static void Main()
            {
                Console.WriteLine("Brij Nagvadiya\n24SOECE11024");

                Console.Write("Enter the number of elements: "); int n = Convert.ToInt32(Console.ReadLine());

                int[] numbers = new int[n];

                // Accept array elements 
                Console.WriteLine("Enter " + n + " values:");

                for (int i = 0; i < n; i++)
                {
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                // Display elements in reverse order 
                Console.WriteLine("\nArray in reverse order:");

                for (int i = n - 1; i >= 0; i--)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }

    }
}

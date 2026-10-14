using System;
using System.Collections.Generic;
using System.Text;

namespace p2
{
    internal class t5_9
    {
        class Program
        {
            static void Main()
            {
                Console.WriteLine("Brij Nagvadiya\n24SOECE11024"); Console.Write("Enter the number of elements: "); int n = Convert.ToInt32(Console.ReadLine());

                int[] numbers = new int[n];

                // Accept array elements 
                Console.WriteLine("Enter " + n + " elements:");

                for (int i = 0; i < n; i++)
                {
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                // Display original array 
                Console.WriteLine("\nOriginal array:");

                for (int i = 0; i < n; i++)
                {
                    Console.Write(numbers[i] + " ");
                }

                // Accept position to delete 
                Console.Write("\n\nEnter the position to delete (1 to " + n + "): "); int position = Convert.ToInt32(Console.ReadLine());

                if (position < 1 || position > n)
                {
                    Console.WriteLine("Invalid position!"); return;
                }

                // Shift elements to the left 
                for (int i = position - 1; i < n - 1; i++)
                {
                    numbers[i] = numbers[i + 1];
                }
                n--;

                // Display array after deletion 
                Console.WriteLine("\nArray after deletion:");

                for (int i = 0; i < n; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }

    }
}

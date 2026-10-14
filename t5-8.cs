using System;
using System.Collections.Generic;
using System.Text;

namespace p2
{
    internal class t5_8
    {

        class Program
        {
            static void Main()
            {
                Console.WriteLine("Brij Nagvadiya\n24SOECE11024"); Console.Write("Enter the number of elements: ");
                int n = Convert.ToInt32(Console.ReadLine());

                int[] numbers = new int[n];

                // Accept array elements 
                Console.WriteLine("Enter " + n + " elements:");

                for (int i = 0; i < n; i++)
                {
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                // Sort in descending order 
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (numbers[i] < numbers[j])
                        {
                            int temp = numbers[i]; numbers[i] = numbers[j];
                            numbers[j] = temp;
                        }
                    }
                }

                // Display sorted array 
                Console.WriteLine("\nArray in descending order:");

                for (int i = 0; i < n; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace p2
{
    internal class t5_1
    {

        class Program
        {
            static void Main()
            {
                int[] numbers = new int[5];
                Console.WriteLine("Brij Nagvadiya\n24SOECE11024");
                // Store elements 
                Console.WriteLine("Enter 5 numbers:");

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                // Print elements 
                Console.WriteLine("\nArray elements are:");

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
            }

        }
    }
}

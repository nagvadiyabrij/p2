using System;
using System.Collections.Generic;
using System.Text;

namespace p2
{
    internal class t5_2
    {
        class Program
        {
            static void Main()
            {
                int[] numbers = new int[5];
                Console.WriteLine("Brij Nagvadiya\n24SOECE11024");

                // Accept 5 integer values 
                Console.WriteLine("Enter 5 integer values:");

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                // Sorting in ascending order 
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        if (numbers[i] > numbers[j])
                        {
                            int temp = numbers[i]; numbers[i] = numbers[j];
                            numbers[j] = temp;
                        }
                    }
                }

                // Display sorted array 
                Console.WriteLine("\nArray in ascending order:");

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }

}


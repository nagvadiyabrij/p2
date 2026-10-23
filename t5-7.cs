using System;
using System.Collections.Generic;
using System.Text;

namespace p2
{
    internal class t5_7
    {
        class Program
        {
            static void Main()
            {
                Console.WriteLine("Brij Nagvadiya\n24SOECE11024"); Console.Write("Enter the number of elements: ");
                int n = Convert.ToInt32(Console.ReadLine());

                int[] numbers = new int[n]; 
                int[] even = new int[n];
                int[] odd = new int[n];

                int evenCount = 0;
                int oddCount = 0;

                // Accept array elements 
                Console.WriteLine("Enter " + n + " integers:");

                for (int i = 0; i < n; i++)
                {
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                // Separate odd and even numbers 
                for (int i = 0; i < n; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        even[evenCount] = numbers[i];
                        evenCount++;
                    }
                    else
                    {
                        odd[oddCount] = numbers[i];
                        oddCount++;
                    }
                }

                // Display even numbers 
                Console.WriteLine("\nEven numbers:");

                for (int i = 0; i < evenCount; i++)
                {
                    Console.Write(even[i] + " ");
                }

                // Display odd numbers 
                Console.WriteLine("\n\nOdd numbers:");

                for (int i = 0; i < oddCount; i++)
                {
                    Console.Write(odd[i] + " ");
                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace p2
{
    internal class t5_6
    {

        class Program
        {
            static void Main()
            {
                Console.WriteLine("Brij Nagvadiya\n24SOECE11024"); Console.Write("Enter the number of elements: "); int n = Convert.ToInt32(Console.ReadLine());

                int[] numbers = new int[n];

                Console.WriteLine("Enter " + n + " elements:");

                for (int i = 0; i < n; i++)
                {
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                int max = numbers[0];
                int min = numbers[0];

                for (int i = 1; i < n; i++)
                {
                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                    }

                    if (numbers[i] < min)
                    {
                        min = numbers[i];
                    }
                }

                Console.WriteLine("\nMaximum element = " + max);
                Console.WriteLine("Minimum element = " + min);
            }
        }

    }
}

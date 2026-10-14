using System;
using System.Collections.Generic;
using System.Text;

namespace p2
{
    internal class t5_5
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

                int duplicateCount = 0;

                for (int i = 0; i < n; i++)
                {
                    bool isDuplicate = false;

                    for (int j = 0; j < i; j++)
                    {
                        if (numbers[i] == numbers[j])
                        {
                            isDuplicate = true;
                            break;
                        }
                    }

                    if (isDuplicate)
                        continue;

                    for (int j = i + 1; j < n; j++)
                    {
                        if (numbers[i] == numbers[j])
                        {
                            duplicateCount++;
                            break;
                        }
                    }
                }

                Console.WriteLine("\nNumber of duplicate elements = " + duplicateCount);
            }
        }

    }
}

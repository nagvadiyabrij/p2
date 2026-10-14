using System;
using System.Collections.Generic;
using System.Text;

namespace p2
{
    internal class SecondLargestNumber
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            Console.WriteLine("Enter 5 numbers:");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int largest, secondLargest;

            // Initialize largest and secondLargest
            if (arr[0] > arr[1])
            {
                largest = arr[0];
                secondLargest = arr[1];
            }
            else
            {
                largest = arr[1];
                secondLargest = arr[0];
            }

            // Find largest and second largest
            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] > largest)
                {
                    secondLargest = largest;
                    largest = arr[i];
                }
                else if (arr[i] > secondLargest && arr[i] != largest)
                {
                    secondLargest = arr[i];
                }
            }

            Console.WriteLine("Largest Number = " + largest);
            Console.WriteLine("Second Largest Number = " + secondLargest);
        }
    }
}
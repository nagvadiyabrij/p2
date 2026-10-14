using System;
using System.Collections.Generic;
using System.Text;

namespace p2
{
    internal class second_smallest_element
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter 5 numbers:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int smallest, secondSmallest;
            // Initialize smallest and secondSmallest
            if (arr[0] < arr[1])
            {
                smallest = arr[0];
                secondSmallest = arr[1];
            }
            else
            {
                smallest = arr[1];
                secondSmallest = arr[0];
            }
            // Find smallest and second smallest
            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] < smallest)
                {
                    secondSmallest = smallest;
                    smallest = arr[i];
                }
                else if (arr[i] < secondSmallest && arr[i] != smallest)
                {
                    secondSmallest = arr[i];
                }
            }
            Console.WriteLine("Smallest Number = " + smallest);
            Console.WriteLine("Second Smallest Number = " + secondSmallest);
        }


    }
}

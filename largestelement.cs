using System;
using System.Collections.Generic;
using System.Text;

namespace p2
{
    internal class largestelement
    {
        public static void largest()
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter 5 numbers: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int largest = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > largest)
                {
                    largest = arr[i];
                }
            }
            Console.WriteLine("The largest number is: " + largest);
        }
    }
}

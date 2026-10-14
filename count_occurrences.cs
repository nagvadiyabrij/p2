using System;
using System.Collections.Generic;
using System.Text;

namespace p2
{
    internal class count_occurrences
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter 5 numbers:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the number to count occurrences:");
            int Count = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            for(int i= 0; i < count; i++)
            {
                count++;
            }
            Console.WriteLine("your number count of " + count);
            
        }
    }
}

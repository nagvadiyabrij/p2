using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace p2
{
    internal class linear_search
    { 
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter numbers:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the number to search:");
            int searchNumber = Convert.ToInt32(Console.ReadLine());
            bool found = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == searchNumber)
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine("Number found in the array.");
            }
            else
            {
                Console.WriteLine("Number not found in the array.");
            }
        }
    }
}

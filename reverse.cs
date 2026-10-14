using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace p2
{
    internal class reverse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your n :");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your element:");
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("original arr :");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + " ");

            }
            Console.WriteLine();

            Console.WriteLine("reverse array:");
            for(int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i] + "");
            }
            Console.WriteLine();

            Console.WriteLine("enter your postion :");

            int pos = Convert.ToInt32(Console.ReadLine());

            if(pos > 0)
            {
                pos++;
            }
            Console.WriteLine("your position" + pos);

           
        }
    }
}

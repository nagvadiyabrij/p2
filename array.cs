using System;
using System.Collections.Generic;
using System.Text;

namespace p2
{
    class array
    {
        public static void array1()
        {
            int[] a = new int[5];
            //task 1 - input five element into this array
            for(int i = 0;i<a.Length;i++)
            {
                Console.Write("enter no : ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            //task - 2 print this array
            Console.WriteLine("array elements are : ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
            }
            Console.WriteLine();
            // task - 3 find and print sum and avg of all elements

            int sum = 0;
            for(int i = 0;i < a.Length; i++) 
            {
                sum += a[i];
                
            }
            Console.WriteLine("sum :" + sum);
            float avg = sum / 5;
            Console.WriteLine("avg :" + avg);

            //task - 4 find and print min and max of all element
            int min = a[0];
            int max = a[0];
            for (int i=0;i<a.Length;i++)
            {
              
                if (a[i] < min)
                
                    min = a[i];
                
                if (a[i] > max)
                
                    max = a[i];
                


            }
            Console.WriteLine("min :" + min);
            Console.WriteLine("max :" + max);
        }
    }
}

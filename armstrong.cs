using System;
using System.Collections.Generic;
using System.Text;

namespace p2
{
    internal class armstrong
    {
        public static void armstrongnumber()
        {
            int num, sum = 0, temp, remainder;
            Console.Write("Enter a three-digit integer: ");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while (temp != 0)
            {
                remainder = temp % 10;
                sum += remainder * remainder * remainder;
                temp /= 10;
            }
            if (sum == num)
                Console.WriteLine("{0} is an Armstrong number.", num);
            else
                Console.WriteLine("{0} is not an Armstrong number.", num);
        }
    }
}

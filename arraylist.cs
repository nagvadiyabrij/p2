using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace p2
{
    internal class arraylist
    {
        public static void Main()
        {
            ArrayList A = new ArrayList();
            A.Add("A");
            A.Add("S");
            A.Add("P");
            Console.WriteLine("Number of Elements :" + A.Count);
            A.Remove("A");
            foreach (string str in A)
                Console.WriteLine(str + " ");
            Console.ReadKey();
        }
    }
}

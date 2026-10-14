using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace p2
{
    internal class collection
    {
        public static void Main(string[] args)
        {
            ArrayList obj = new ArrayList();

            obj.Add("RKU");
            obj.Add(110);
            obj.Add(115.25);
            obj.Add("x");
            obj.Add(true);

            Console.WriteLine("number of element :" + obj.Count);
            obj.Remove("RKU");

            foreach (object str in obj)
                Console.WriteLine(str + " ");
            Console.ReadKey();

        }
    }
}

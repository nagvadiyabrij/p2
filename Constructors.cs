using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace p2
{
    internal class Constructors
    {
        static void Main(string[] args)
        {
            ArrayList al1 = new ArrayList();
            ArrayList al2 = new ArrayList(10);
            int[] intArr = new int[10];
            ArrayList al3 = new ArrayList(intArr);
            ArrayList myArrayList = new ArrayList();
            myArrayList.Capacity = 10;
            int[] intArr2 = { 2, 3, 4, 5 };
            myArrayList.Add(1);
            myArrayList.AddRange(intArr2);
            Console.WriteLine(myArrayList.Capacity);
            myArrayList.Remove(1);
            myArrayList.RemoveRange(1, 2);
            myArrayList.Insert(1, 3);



            myArrayList.InsertRange(0, intArr);
            foreach (object elem in myArrayList)
            {
                Console.WriteLine(elem);
            }
        }
    }
}

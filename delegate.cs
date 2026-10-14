using System;
using System.Collections.Generic;
using System.Text;

namespace p2
{
    internal class @delegate
    {
        delegate void MyDelegate();

        static void Hello()
        {
            Console.WriteLine("Hello Brij");
        }

        static void Main()
        {
            MyDelegate d = Hello;

            d();   
        }
    }
}

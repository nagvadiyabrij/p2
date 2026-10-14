using System;
using System.Collections.Generic;
using System.Text;

namespace p2
{
    internal class delegate_demo
    {

            delegate void mydelegate(int x, int y);

            class delegate_demo2
            {
                public static void add(int x, int y)
                {
                    Console.WriteLine(x + y);
                }
            public static void sub(int x, int y)
            {
                Console.WriteLine(x - y);
            }
            public static void mul(int x, int y)
            {
                Console.WriteLine(x * y);
            }
            public static void div(int x, int y)
            {
                Console.WriteLine(x / y);
            }

            public static void Main(string[] args)
                {
                //instatiation of delegate
                mydelegate obj = new mydelegate(add);
                    obj += sub;
                    obj += mul;
                    obj += div;
                //invocation (calling add,sub,mul,div methods)
                    obj(15, 5);


                Console.Read();
                }

            }
        }
    }


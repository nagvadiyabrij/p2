using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace p2
{
    internal class demo
    {
        class empolyess
        {
            public string Names { get; set; }
            private int age;
            public string Dept { get; set; }
            private double Salary;

            public void setSalary(double salary)
            {
                this.Salary = salary;
            }
            public double getSalary()
            {
                return this.Salary;
            }
            public int Age
            {
                get
                {
                    return age;
                }
                set
                {
                    age = value;
                }
            }

            public void diplay()
            {
                Console.WriteLine("name: " + Names);
                Console.WriteLine("age: " + age);
                Console.WriteLine("dept: " + Dept);
                Console.WriteLine("salary :" + Salary);

            }

            class demo
            {
                static void Main(string[] args)
                {
                    empolyess e1 = new empolyess();
                    e1.Names = "ramesh";
                    e1.Age = 20;
                    e1.Dept = "CSE";
                    e1.setSalary(10000);
                    e1.diplay();

                    empolyess e2 = new empolyess();
                    e2.Names = "raj";
                    e2.Age = 30;
                    e2.Dept = "IT";
                    e2.setSalary(20000);
                    e2.diplay();

                }
            }

        }
    }
}
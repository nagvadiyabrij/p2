using System;
using System.Collections.Generic;
using System.Text;

namespace p2
{
    internal class t5_10
    {
        class Program
        {
            static void Main()
            {
                Console.WriteLine("Brij Nagvadiya\n24SOECE11024"); Console.Write("Enter number of rows: ");
                int rows = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number of columns: ");
                int columns = Convert.ToInt32(Console.ReadLine());

                int[,] matrix1 = new int[rows, columns]; int[,] matrix2 = new int[rows, columns];
                int[,] result = new int[rows, columns];

                Console.WriteLine("\nEnter elements of first matrix:");

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine("\nEnter elements of second matrix:");

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        result[i, j] = matrix1[i, j] + matrix2[i, j];
                    }
                }

                Console.WriteLine("\nResult of matrix addition:");

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write(result[i, j] + "\t");
                    }

                    Console.WriteLine();
                }
            }
        }
    }

}


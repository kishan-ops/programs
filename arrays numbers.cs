﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] a = new int [,] { { 10, 20, 30}, {40, 50, 60 },{70,80,90}};
            
                for (int i = 0; i<=a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(2); j++)
                    {
                        Console.Write(a[i, j] + " ");

                    }
                    Console.WriteLine();
                }

                Console.ReadLine();


        }
    }
}

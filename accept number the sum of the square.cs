using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int square = 0;
            int sum = 0;
            for (int i = 1; i <= 3; i++)
            {
                square = i * i;
                sum = sum + square;
                Console.Write(i + " ");
            }
            Console.WriteLine("\nsume of the square is:"+sum);
            Console.ReadLine();
        }
    }
}

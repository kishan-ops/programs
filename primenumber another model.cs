using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the values");
            int n = int.Parse(Console.ReadLine());
            int i = 2;
            while (i < n)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("it is not prime number");
                    break;
                }
                i++;
            }
            if (i == n)
                Console.WriteLine("it is prime number");//prime no are: 2,3,5,7,11,13,17,19,23,29,31..........

            Console.ReadLine();
        }
    }
}

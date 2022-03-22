using System;
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
            Console.WriteLine("enter the values");
            int n = int.Parse(Console.ReadLine());
            int ctr=0;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    ctr++;
                }
            }
            if (ctr == 0)
            {
                Console.WriteLine("it is prime number");//prime no are: 2,3,7,11,13,17,19,23,29,31...
            }
            else
            {
                Console.WriteLine("it is not prime number");
            }
                Console.ReadLine();
        }
    }
}

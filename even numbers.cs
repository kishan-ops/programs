using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter ur number");
            int n = int.Parse(Console.ReadLine());
            
                if (n % 1 == 0)
                {
                    Console.WriteLine("it is prime number");//even number are 2,4,6,8,10,12,14,16,18,20
                }
                else
                {
                    Console.WriteLine("it is not prime number");
                }
            
            
            Console.ReadLine();
        }
    }
}

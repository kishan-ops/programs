using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the thrird number");
            int c = int.Parse(Console.ReadLine());
            if (a < b && a < c)
            {
                Console.Write("a is smallest");
            }
            else if (b < c)
            {
                Console.Write("b is smallest");
            }
            else
                Console.WriteLine("c is smallest");
            Console.ReadLine();
        }
    }
}

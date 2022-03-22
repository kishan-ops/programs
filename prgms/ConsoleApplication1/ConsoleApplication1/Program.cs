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
            int sum = 0, ctr = 0, n;
            Console.WriteLine("Enter ur range");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("list of even no's are:");
            for (int i = 2; i <= n; i = i + 2)
            {
                Console.Write(i + " \n");
                sum = sum + i;
                ctr++;
            }
            Console.WriteLine("sum of even no's are:" + sum);
            Console.WriteLine("No of even nos r:" + ctr);

            Console.ReadLine();
        }
        
    }
}

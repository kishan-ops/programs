using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 3; i++)
            {
                int cube = i * i * i;
                sum = sum + cube;
                Console.Write(i + " ");
            }
            Console.Write("\nsume of the cube:" + sum);
            Console.ReadLine();
        }
    }
}

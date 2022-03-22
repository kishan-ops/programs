using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class calculate
    {
        internal void add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("addition result is:" + c);
        }
        internal void sub(int a, int b)
        {
            int c = a - b;
            Console.WriteLine("sub result is:" + c);
        }
        internal int mul(int a, int b)
        {
            int c = a * b;
            return c;
        }
        internal int div(int a, int b)
        {
            int c = a / b;
            return c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            calculate obj = new calculate();
            obj.add(10, 5);
            obj.sub(10, 5);
            int res = obj.mul(10, 5);
            Console.WriteLine("mul result is:" + res);
            res = obj.div(10, 5);
            Console.WriteLine("div result is:" + res);
            Console.ReadLine();
        }
    }
}

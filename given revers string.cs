using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter ur string");
            String str1 = Console.ReadLine();
            string str2 = null;
            for (int i = str1.Length - 1; i >= 0; i--)
            {
                str2 = str2 + str1[i];
            }
            Console.Write(str2);
            
            Console.ReadLine();
        }
    }
}

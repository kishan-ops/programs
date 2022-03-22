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
            Console.WriteLine("enter customer id:");
            int cid = int.Parse(Console.ReadLine());
            Console.WriteLine("enter custer name:");
            string cname = Console.ReadLine();
            Console.WriteLine("enter consumed units:");
            ulong cunits = ulong.Parse(Console.ReadLine());
            Console.WriteLine("enter customer type:\n press for 1 industry\n press for 2 residential\n press for 3 service oriented organization\n press for 4 endoment\n press for 5 ariculture\n");
            byte ctype = byte.Parse(Console.ReadLine());
            double totbill = cunits;
            switch (ctype)
            {
                case 1:
                    if (cunits <= 100)
                    {
                        Console.WriteLine("total bill is:" + cunits*8);
                    }
                    else if (cunits <= 150)
                    {
                        Console.WriteLine("total bill is:" + cunits*10);
                    }

                    else
                    {
                        if (cunits <= 200)
                        {
                            totbill = cunits * 15;
                            Console.WriteLine("total bill is:" + totbill);
                        }
                        else if (cunits <= 300)
                        {
                            totbill = cunits * 20;
                            Console.WriteLine("total bill is:" + totbill);
                        }
                        else
                        {
                            totbill = cunits * 30;
                            Console.WriteLine("total bill is:" + totbill);
                        }
                    }
                    break;
                case 2:
                    if (cunits <= 100)
                    {
                        totbill = cunits * 5;
                        Console.WriteLine("total bill is:" + totbill);
                    }
                    else if (cunits <= 200)
                    {
                        totbill = cunits * 6;
                        Console.WriteLine("total bill is:" + totbill);
                    }
                    else
                    {
                        if (cunits <= 300)
                        {
                            totbill = cunits * 10;
                            Console.WriteLine("total bill is:" + totbill);
                        }
                        else if (cunits <= 400)
                        {
                            totbill = cunits * 15;
                            Console.WriteLine("total bill is:" + totbill);
                        }
                        else
                        {
                            totbill = cunits * 20;
                            Console.WriteLine("total bill is:" + totbill);
                        }
                    }
                    break;
                case 3:
                    if (cunits <= 200)
                    {
                        totbill = cunits * 2;
                        Console.WriteLine("total bill is:" + totbill);
                    }
                    else if (cunits <= 400)
                    {
                        totbill = cunits * 4;
                        Console.WriteLine("total bill is:" + totbill);
                    }
                    else
                    {
                        if (cunits <= 600)
                        {
                            totbill = cunits * 6;
                            Console.WriteLine("total bill is:" + totbill);
                        }
                        else
                        {
                            totbill = cunits * 8;
                            Console.WriteLine("total bill is:" + totbill);
                        }
                    }
                    break;
                case 4:
                    totbill = cunits * 1;
                    Console.WriteLine("total bill is:" + totbill);
                    break;
                case 5:
                    if (cunits <= 100)
                    {
                        totbill = cunits * 0;
                        Console.WriteLine("total bill is:" + totbill);
                    }
                    else if (cunits <= 300)
                    {
                        totbill = cunits * 3;
                        Console.WriteLine("total bill is:" + totbill);
                    }
                    else
                    {
                        totbill = cunits * 5;
                        Console.WriteLine("total bill is:" + totbill);
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}

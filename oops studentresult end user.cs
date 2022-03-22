using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class student
    {
        double sid;
        string sname;
        double totmarks;
        double avgmarks;
        string result;
        internal student(double stid, string stname)
        {
            sid = stid;
            sname = stname;
        }
        internal void calresult(double m1, double m2, double m3)
        {
            totmarks = m1 + m2 + m3;
            avgmarks = totmarks / 3;
            if (avgmarks >= 60)
            {
                result = "first class";
            }
            else if (avgmarks>=50&&avgmarks<60)
            {
                result = "second class";
            }
            else if (avgmarks >= 35&&avgmarks<50)
            {
                result = "third class";
            }
            else
                result = "fail";
        }
        internal void Displaymarks()
        {
            Console.WriteLine(sname + "total marks are:" + totmarks);
            Console.WriteLine(sname + "avg marks are:" + avgmarks);
            Console.WriteLine(result);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter m1 marks:");
            double m1=double.Parse(Console.ReadLine());
            Console.WriteLine("enter m2 marks:");
            double m2=double.Parse(Console.ReadLine());
            Console.WriteLine("enter m3 marks:");
            double m3=double.Parse(Console.ReadLine());
            student stobj=new student(111,"rama");
            stobj.calresult(m1,m2,m3);
            stobj.Displaymarks();
            Console.ReadLine();
        }
    }
}

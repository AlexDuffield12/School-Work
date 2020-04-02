using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsharpensGists
{
    class Program
    {
        static void Main(string[] args)
        {
            double h, p, b, sqh;

            Console.WriteLine("Please Enter the Value of Perpendicular");
            p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter the Value of Base");
            b = Convert.ToDouble(Console.ReadLine());

            sqh = p * p + b * b;

            h = Math.Sqrt(sqh);

            Console.WriteLine("Hypotenius is {0}", h);
            Console.ReadLine();
        }
    }
}
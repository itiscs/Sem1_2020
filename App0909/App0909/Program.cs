using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App0909
{
    class Program
    {
        static void Main(string[] args)
        {
            //double x=0.5, y=0.5;

            //if (x < 0)
            //{
            //    if ((y <= 1) && (y >= -1) && (x >= -1))
            //    {
            //        Console.WriteLine("да");
            //    }
            //    else
            //    {
            //        Console.WriteLine("нет");
            //    }
            //}
            //else
            //{
            //    if (x * x + y * y >= 0)
            //    {
            //        Console.WriteLine("да");
            //    }
            //    else
            //    {
            //        Console.WriteLine("нет");
            //    }

            //}

            //x = double.Parse(Console.ReadLine());

            //y = double.Parse(Console.ReadLine());


            //double z = x;
            //x = y;
            //y = z;

            

            //if (((y <= x + 1) && (y >= - x - 1) && x <= 0)
            //    || 
            //    ((y <= x * x) && y >= -(x * x) && x <= 1))
            //    Console.WriteLine($"Координата({x},{y}) принадлежит данной области");
            //else
            //    Console.WriteLine($"Координата({x},{y}) не принадлежит данной области");



            int a = 5, b = 6;
            Console.WriteLine($"{a} {b} ");

            b = a + b;
            Console.WriteLine($"{a} {b} ");

            a = b - a;
            Console.WriteLine($"{a} {b} ");

            b = b - a;
            Console.WriteLine($"{a} {b} ");



        }
    }
}

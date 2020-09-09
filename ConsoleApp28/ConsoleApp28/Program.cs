using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {

            //int x, abs;

            ////x = double.Parse(Console.ReadLine());
            //x = Convert.ToInt32(Console.ReadLine());
            //x = x / 3;

            //if (x >= 0)
            //{
            //    abs = x;
            //}
            //else
            //{
            //    abs = -x;
            //}

            //Console.WriteLine($"{abs}");

            int a, b, c, max;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());


            if (a >= b && a >= c)
                max = a;
            else 
            {
                if (b >= c)
                    max = b;
                else
                    max = c;
            }
            Console.WriteLine(max);

            













        }
    }
}

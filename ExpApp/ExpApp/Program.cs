using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, n, y, stepen, t;
            x = Convert.ToDouble(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            y = 0;
            stepen = 1;
            t = -1;
            for (int i = 1; i <= n; i++)
            {
                t *= -1;
                stepen *= x;
                y += t * (stepen / i);
            }
            Console.WriteLine(y);
            Console.WriteLine(Math.Log(1 + x));
        }
    }
}

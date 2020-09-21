using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FactApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, res, xk;
            int n;
            
            x = Convert.ToDouble(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());

            res = 0;
            xk = 1;
            for (int i = 0; i < n; i++)
            {
                xk *= x;
                res += Math.Cos(xk);
            }

            Console.WriteLine(res);
            

            
        }
    }
}

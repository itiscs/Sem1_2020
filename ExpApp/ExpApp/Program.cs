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
            double x, exp, n, y, fact, stepen;
            x = Convert.ToInt32(Console.ReadLine());
            //n = Convert.ToInt32(Console.ReadLine());
            exp = 0.0000001; 
            y = 1;
            fact = 1;
            stepen = 1;
            int i=1;
            //for (int i = 1; i <= n; i++)
            while(stepen/fact >= exp)
            {
                fact *= i;
                stepen *= x;
                y += stepen / fact;
                i++;
            }
            Console.WriteLine(y);
            Console.WriteLine(Math.Exp(x));
            Console.WriteLine(i);
            Math.Log(1 + x);
        }
    }
}

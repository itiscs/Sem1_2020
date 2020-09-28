using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NODApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, z;
            int n;
            bool fl = false;
            x = Convert.ToDouble(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            z = 1;
            
            for (int i = 0; i <= n; i++)
            {
                z *= x;
                while (Math.Sin(z) < 0)
                { 
                    fl = true; break;
                }

            }
            if (fl)
                Console.WriteLine("да");
            else
                Console.WriteLine("нет");
        }
    }
    
}

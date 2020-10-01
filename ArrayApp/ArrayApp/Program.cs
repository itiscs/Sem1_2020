using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int N = 10;

            int[] mas = new int[N];

            int sum = 0, k = 0, prod = 1;

            int max;// = int.MinValue;


            for (int i = 0; i < N; i++)
                mas[i] = r.Next(-10,10);


            max = mas[0];
            int imax = 0;

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"mas[{i}] = {mas[i]}");
                if (mas[i] >= 0)
                {
                    sum += mas[i];
                    k++;
                }
                else 
                {
                    prod *= mas[i];
                }
                if (mas[i] > max)
                {
                    max = mas[i];
                    imax = i;
                }
            }


            Console.WriteLine($"sum = {sum} avg = {(double)sum/k}");

            Console.WriteLine($"prod = {prod}");

            Console.WriteLine($"Max = {max}  = mas[{imax}]");



            //int x = 10;









        }
    }
}

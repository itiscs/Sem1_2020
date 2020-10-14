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
            int[] b = { 1, 2, 3, 4, 5 };
            int[] a = { 1, 2, 3, 4, 5, 6 };

            int[] c = new int[a.Length + b.Length];


            //for() в одном цикле

            int k, l, m;
            k = l = m = 0;

            while(k < a.Length && l < b.Length)
            {
                if(a[k] < b[l])
                {
                    c[m++] = a[k++];
                }
                else
                {
                    c[m++] = b[l++];
                }
            }
           // if(k < a.Length) // закончился b
               while (k < a.Length)
                    c[m++] = a[k++];
            //else             // закончился a
                while (l < b.Length)
                    c[m++] = b[l++];

            for (int i = 0; i < c.Length; i++)
                Console.WriteLine(c[i]);


        }
    }
}

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
            int[] b = { 1, 2, 5, 8, 15 };
            int[] a = { 2, 3, 4, 5, 6, 11, 15 };

            int[] c = new int[a.Length + b.Length];

            

            //for() в одном цикле

            int k, l, m;
            k = l = m = 0;
            /*  НЕ УБИРАЕМ ПОВТОРЫ
            for(int i = 0; i < c.Length; i++)
            {
                if (k >= a.Length)//a закончился
                    c[i] = b[l++];
                else if (l >= b.Length)//b закончился
                    c[i] = a[k++];
                else
                {
                    if (a[k] < b[l])
                        c[i] = a[k++];
                    else
                        c[i] = b[l++];
                }
            }
            for (int i = 0; i < c.Length; i++)
                Console.WriteLine(c[i]);

            */
            
            while(k < a.Length && l < b.Length)
            {
                if(a[k] < b[l])
                {
                    c[m++] = a[k++];
                }
                else if(a[k] > b[l])
                {
                    c[m++] = b[l++];
                }
                else // a[k] == b[l]
                {
                    c[m++] = a[k++];
                    l++;
                }
            }
           if(k < a.Length) // закончился b
               while (k < a.Length)
                    c[m++] = a[k++];
            else             // закончился a
                while (l < b.Length)
                    c[m++] = b[l++];
                    
            for (int i = 0; i < m; i++)
                Console.WriteLine(c[i]);


        }
    }
}

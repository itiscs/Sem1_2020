using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegeArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 0, 2, 4, 5, 6, 8 };
            bool fl = true;
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] > a[i + 1])
                {
                    fl = false;
                    break;
                }
                
            }
            if(fl)
                Console.WriteLine("возрастающий массив");
            else
                Console.WriteLine("не возрастающий массив");



        }
    }
}
    
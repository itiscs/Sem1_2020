using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsApp
{
    class Program
    {

        static double Length(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }

        static double Area(double a, double b, double c)
        {
            double p = (a + b + c) / 2;

            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }



        static  void Swap(ref int a,ref int b)
        {
            int k = a;
            a = b;
            b = k;
        }

        static int Max(int a, int b)
        {
            //a = 100;
            if (a > b)
                return a;
            else
                return b;

        }

        static int Max(int[] a)
        {
            a[3] = 100;
            int m = a[0];
            for (int i = 1; i < a.Length; i++)
                if (a[i] > m)
                    m = a[i];
            return m;

        }
        static int Max(List<int> lst)
        {
            lst[2] = 50;
            int m = int.MinValue;
            foreach (var el in lst)
                if (el > m)
                    m = el;
            return m;

        }


        static void Main(string[] args)
        {
            //int k = 4, l = 5;


            //int m = Max(k, l);
            //Console.WriteLine(m);

            //int s = 6;
            //Swap(ref k, ref s);
            //Console.WriteLine($"k = {k}  l = {l}");

            //int N = 5;
            //int[] mas = new int[N];
            //var lst = new List<int>();
            //Random r = new Random();
            //for (int i = 0; i < N; i++)
            //    mas[i] = r.Next(10);

            //for (int i = 0; i < r.Next(10,20); i++)
            //    lst.Add(r.Next(10));



            //for (int i = 0; i < N; i++)
            //    Console.WriteLine(mas[i]);

            //Console.WriteLine($"*********{Max(mas)}");

            //for (int i = 0; i < N; i++)
            //    Console.WriteLine(mas[i]);

            //Console.WriteLine("****************");
            //foreach (var el in lst)
            //    Console.WriteLine(el);

            //Console.WriteLine($"MAX = {Max(lst)}");

            //foreach (var el in lst)
            //    Console.WriteLine(el);

            double x1, x2, x3, y1, y2, y3, x, y;

            x1 = 0;  //A
            y1 = 0;
            x2 = 3;  //B
            y2 = 0;
            x3 = 0;  //C
            y3 = 3;
            x = 1.2;   //D
            y = 1.2;

            double ab, bc, ac, ad, bd, cd;
            ab = Length(x1, x2, y1, y2);
            bc = Length(x2, x3, y2, y3);
            ac = Length(x1, x3, y1, y3);
            ad = Length(x1, x, y1, y);
            bd = Length(x2, x, y2, y);
            cd = Length(x3, x, y3, y);

            double abc, abd, acd, bcd;

            abc = Area(ab, bc, ac);
            abd = Area(ab, bd, ad);
            acd = Area(ad, cd, ac);
            bcd = Area(bd, bc, cd);

            Console.WriteLine(abc);
            Console.WriteLine(abd);
            Console.WriteLine(acd);
            Console.WriteLine(bcd);

            Console.WriteLine(Math.Abs(abc - abd - acd - bcd) < 0.0001);




        }
    }
}

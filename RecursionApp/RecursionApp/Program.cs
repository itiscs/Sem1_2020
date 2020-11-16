using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionApp
{
    class Program
    {

        static long Factorial(int k)
        {
            if (k == 0 || k == 1)
                return 1;

            return k * Factorial(k - 1);

        }

        static int CountOfDigits(long a)
        {
            if (a < 0)
                return CountOfDigits(-a);

            if (a <= 9)
                return 1;

            return 1 + CountOfDigits(a / 10);
        }

        static void ShowNumbers(int[] mas, int i)
        {
            if (i >= mas.Length)
                return;

            if (mas[i] < 0)
            {
                Console.Write($"{mas[i]} ");
                ShowNumbers(mas, i + 1);
            }
            else
            {
                ShowNumbers(mas, i + 1);
                Console.Write($"{mas[i]} ");
            }

        }

        static bool IsStep(int k)
        {
            if (k < 0)
                return IsStep(-k);
            if (k == 0)
                return false;
            if (k == 2)
                return true;
            if (k % 2 == 1)
                return false;
            return IsStep(k / 2);
        }



        static void Main(string[] args)
        {
            long fact;
            int k;

            Console.Write("Введите число:");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine(IsStep(k));

            for (int i = 0; i < 22; i++)
            {
                fact = Factorial(i);
                Console.WriteLine($"{i} ---- {fact}   ---- {CountOfDigits(fact)}");
            }


            int N = 10;
            int[] a = new int[N];
            Random r = new Random();
            for(int i=0; i<N; i++)
            {
                a[i] = r.Next(-100, 100);
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();

            ShowNumbers(a, 0);
                  
            


        }
    }
}

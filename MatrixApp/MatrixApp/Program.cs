using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 5;
            int[,] a =  new int[N,N];

            int[,] a2 = { { 1,2,3}, { 2,3,4}, { 3,4,5} };

            //int[][] b = new int[N][];//кусочно-заданная матрица
            //for (int i = 0; i < N; i++)
            //    b[i] = new int[1 + i];


            //for(int i=0; i<N; i++)
            //    for(int j=0; j<N; j++)
            //        a[i, j] = i * N + j;
            
            for (int i = 0; i < N; i++)
            {
                for (int j = i; j < N; j++)
                {
                   // if (j <= i)
                        a[i, j] = j + 1;
                }
            }

            bool fl = true;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)

                    Console.Write($"{a[i, j], 3} ");

                Console.WriteLine();
            }


            for (int i = 0; i < a2.GetLength(0); i++)
            {
                for (int j = 0; j < a2.GetLength(1); j++)

                    Console.Write($"{a2[i, j],3} ");

                Console.WriteLine();
            }









        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix3
{
    class Program
    {

        static int[,] CreateMatrix()
        {
            Console.WriteLine("Введите размерности матрицы");
            var N = int.Parse(Console.ReadLine());
            var M = int.Parse(Console.ReadLine());
            var matr = new int[N, M];
            Random r = new Random();

            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    matr[i, j] = r.Next(0, 2);

            return matr;
        }

        static int[,] Mutliplication(int[,] a, int[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0))
                throw new ArgumentException("Матрицы не умножаются");
            
            var matr = new int[a.GetLength(0), b.GetLength(1)];
            
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    matr[i, j] = 0;
                    for (int k = 0; k < a.GetLength(1); k++)
                        matr[i, j] += a[i, k] * b[k, j];
                }

            return matr;
        }

        static int CountNullRows(int[,] matr)
        {
            int count = 0;
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                bool rowIsNull = true;
                for (int j = 0; j < matr.GetLength(1); j++)
                    if (matr[i, j] != 0)
                    {
                        rowIsNull = false;
                        break;
                    }
                if (rowIsNull)
                    count++;
            }
            return count;
        }



        static void ShowMatrix(int[,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < matr.GetLength(1); j++)
                    Console.Write($"{matr[i, j],5}");
            }
            Console.WriteLine();
            
        }




        static void Main(string[] args)
        {
            var A = CreateMatrix();
            var B = CreateMatrix();
            var C = Mutliplication(A, B);


            ShowMatrix(A);
            Console.WriteLine("**********************************");
            ShowMatrix(B);

            Console.WriteLine("**********************************");

            ShowMatrix(C);
            Console.WriteLine("**********************************");


            Console.WriteLine($"A-{CountNullRows(A)} B-{CountNullRows(B)} C-{CountNullRows(C)}");


        }
    }
}

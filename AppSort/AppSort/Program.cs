﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSort
{
    class Program
    {
        static int[] CreateArray(int N)
        {
            int[] mas = new int[N];
            Random r = new Random();
            for (int i = 0; i < N; i++)
                mas[i] = r.Next(-100, 100);
            return mas;

        }
        static void ShowArray(int[] mas)
        {
            int N = mas.Length;
            for (int i = 0; i < N; i++)
                Console.Write($"{mas[i]} ");
            Console.WriteLine();

        }
        /// <summary>
        /// сортировка положительные и отрицательные
        /// </summary>
        /// <param name="mas"></param>
        static void ArraySort1(int[] mas)
        {
            int N = mas.Length;
            int left = 0, right = N - 1;
            while(left < right)
            {
                if (mas[left] < 0)
                    left++;
                else
                {
                    int temp = mas[right];
                    mas[right] = mas[left];
                    mas[left] = temp;
                    right--;
                }
            }

        }

        /// <summary>
        /// Сортировка пузырьком
        /// </summary>
        /// <param name="mas"></param>
        static void BubbleSort(int[] mas)
        {
            int N = mas.Length;
            //for (int j = N; j > 1; j--)
            //{
            //    for (int i = 0; i < j - 1; i++)
            //        if (mas[i] > mas[i + 1])
            //        {
            //            int temp = mas[i];
            //            mas[i] = mas[i + 1];
            //            mas[i + 1] = temp;
            //        }
            //    ShowArray(mas);
            //}
            while(true)
            {
                bool fl = true;
                for (int i = 0; i < N - 1; i++)
                    if (mas[i] > mas[i + 1])
                    {
                        int temp = mas[i];
                        mas[i] = mas[i + 1];
                        mas[i + 1] = temp;
                        fl = false;
                    }
                //ShowArray(mas);
                if (fl)
                    break;
                 }

        }
        /// <summary>
        /// Сортировка max
        /// </summary>
        /// <param name="mas"></param>

        static void SortTry(int[] mas)
        {
            int NumOfSorted = 0;
            bool isSorted = true;
            while (true)
            {
                int max = int.MinValue;
                int indexOfMax = 0;
                for (int i = 0; i < mas.Length - NumOfSorted; i++)
                {
                    if (mas[i] > max)
                    {
                        max = mas[i];
                        indexOfMax = i;
                        isSorted = false;
                    }
                }
                if (isSorted || NumOfSorted >= mas.Length - 1)
                    break;
                int temp = mas[mas.Length - NumOfSorted - 1];
                mas[mas.Length - NumOfSorted - 1] = mas[indexOfMax];
                mas[indexOfMax] = temp;
                NumOfSorted++;
               // ShowArray(mas);
            }
        }


        static int BinSearch(int[] mas, int x, int l, int r)
        {
            if (l >= r)
                return -1;
            int m = (l + r) / 2;
            Console.WriteLine($"a[{m}] = {mas[m]}");
            if (mas[m] == x)
                return m;
            if (mas[m] > x)
                return BinSearch(mas, x, l, m);
            else
                return BinSearch(mas, x, m, r);
        }

        static int BinSearch(int[] mas, int x)
        {
            int l = 0, r = mas.Length , m;
            return BinSearch(mas, x, l, r);

            //while (l < r)
            //{
            //    m = (l + r) / 2;
            //    if (mas[m] == x)
            //        return m;
            //    if (mas[m] > x)
            //        r = m;
            //    else
            //        l = m;
            //    Console.WriteLine($"a[{m}] = {mas[m]}");
            //}
            //return -1;
        }
        

        static int[] MergeSort(int[] mas, int l, int r)
        {
            if(l == r) // остался кусок массива их одного элемента
            {
                int[] mas1 = new int[1];
                mas1[0] = mas[r];
                Console.Write($"l - {l} r - {r}  mas: ");
                ShowArray(mas1);
                return mas1; 
            }
            int m = (l + r) / 2;
            var mas_left  = MergeSort(mas, l, m);
            var mas_right = MergeSort(mas, m + 1, r);

            int left_size = mas_left.Length;
            int right_size = mas_right.Length;
            int merge_size = left_size + right_size;
            int[] mas_merge = new int[merge_size];

            int k = 0, n = 0;
            for (int i = 0; i < mas_merge.Length; i++)
            {
                if (k >= left_size)//mas_left закончился
                    mas_merge[i] = mas_right[n++];

                else if (n >= right_size)//mas_right закончился
                    mas_merge[i] = mas_left[k++];

                else  // оба массива ещё есть
                {
                    if (mas_left[k] < mas_right[n])
                        mas_merge[i] = mas_left[k++];
                    else
                        mas_merge[i] = mas_right[n++];
                }
            }
            Console.Write($"l - {l} r - {r}  mas: ");
            ShowArray(mas_merge);
            return mas_merge;
        }





        static void Main(string[] args)
        {
            int N = 20;
            var a = CreateArray(N);
            Console.WriteLine("Исходный массив:");
            ShowArray(a);
            // отриц влево, положительные вправо
            //ArraySort1(a);
            //Console.WriteLine("Первая сортировка:");
            //ShowArray(a);
            // отриц влево, положительные вправо
            //BubbleSort(a);
            //Console.WriteLine("Cортировка пузырьком:");
            //ShowArray(a);


            //SortTry(a);
            //Console.WriteLine("Cортировка максимумами:");
            //ShowArray(a);

            a = MergeSort(a, 0, a.Length - 1);
            Console.WriteLine("Cортировка слиянием:");
            ShowArray(a);



            //int x = int.Parse(Console.ReadLine());
            //var ind = BinSearch(a, x);

            //Console.WriteLine($"Номер элемента: {ind}");



        }
    }
}

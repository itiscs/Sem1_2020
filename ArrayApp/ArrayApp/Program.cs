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
            
            int[] mas = { 1, 2, 3, 3, 4, 2, 56, 5, 3 };
            int N = mas.Length;
            //Random r = new Random();
            //for (int i = 0; i < N; i++)
            //    mas[i] = r.Next(0, 10);
            for (int i = 0; i < N; i++)
                Console.Write($"{mas[i]} ");
            Console.WriteLine();

            int kolvo = 0, kolvo2 = 0; ;
            for (int i = 0; i < N; i++)
            {
                bool noRepeat = true;
                for (int i1 = i + 1; i1 < N; i1++)
                {
                    if (mas[i] == mas[i1])
                    {
                        noRepeat = false;
                        break;
                    }
                }
                if (noRepeat)
                    kolvo++;

                bool isUnique = true; 
                for (int i1 = 0; i1 < N; i1++)
                {
                    if (mas[i] == mas[i1] && i != i1)
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                    kolvo2++;



            }
            Console.WriteLine($"Различные {kolvo}");
            Console.WriteLine($"Уникальные {kolvo2}");







        }
    }
}

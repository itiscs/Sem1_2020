using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int[] mas = new int[10];

            List<int> lst = new List<int>();

            int n = r.Next(10, 20);
            for (int i = 0; i < n; i++)
            {
                lst.Add(r.Next(100));
                Console.WriteLine($"Count - {lst.Count}   {lst.Capacity}");
            }

            
            //Console.WriteLine($"N = {n}");
            //for (int i = 0; i < n; i++)
            //    Console.WriteLine(lst[i]);

            //for (int i = 0; i < n; i++)
            //    Console.WriteLine(lst[i]);

            //foreach(var elem in lst)
            //    Console.WriteLine(elem);

            //lst.RemoveAll(elem => elem > 20);
            //Console.WriteLine($"Count - {lst.Count}   {lst.Capacity}");


            //foreach (var elem in lst)
            //{
            //    Console.WriteLine(elem);
            //}



            String str = "abfdjfkdfjkdjfklaaaaaaf";
            
            List<char> lst2 = new List<char>();
            char a = 'a';
            int k = (int)a;
            Console.WriteLine(k);

            foreach(var ch in str)
            {
                //if (lst2.Contains(ch))
                //    continue;
                //else
                //    lst2.Add(ch);                
                if (!lst2.Contains(ch))
                    lst2.Add(ch);
            }

            foreach (var ch in lst2)
            {
                Console.Write(ch);
            }
            Console.WriteLine();

            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (var ch in str)
            {
                if (dict.ContainsKey(ch))
                {
                    dict[ch]++;                    
                }
                else
                {
                    //dict.Add(ch, 1);
                    dict[ch] = 1;
                }
            }

            foreach (var d in dict)
            {
                //Console.WriteLine(d);
                Console.WriteLine($"{d.Key}   {d.Value}");
            }
            
        }
    }
}

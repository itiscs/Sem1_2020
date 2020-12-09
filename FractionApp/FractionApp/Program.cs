using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Fraction[] mas = new Fraction[10];

            var nc = new NewClass();
            //Random r = new Random();
            //Console.WriteLine(r.GetType());
            Console.WriteLine(nc);

            int x = 4;
            
            Fraction dr1 = new Fraction(8,8);
            Console.WriteLine(dr1);


            //dr1.SetChisl(4);
            //dr1.SetZnam(5);

            //dr1.ShowFraction();
            Console.WriteLine(dr1);

            Fraction dr2 = new Fraction();

            dr2.Chisl = 7;
            dr2.Znam = 9;
            //dr2.SetChisl(7);
            //dr2.SetZnam(9);

            //dr2.ShowFraction();
            Console.WriteLine(dr2.Chisl + dr2.Znam);



            Fraction dr3 = new Fraction(5);
            dr3.ShowFraction();


            Fraction dr4 = new Fraction(3,6);
            dr4.Sokr();
            dr4.ShowFraction();


            dr4.Add(dr2);
            dr4.ShowFraction();


            var dr6 = Fraction.Add(dr4, dr2);
            Console.WriteLine($"{dr4} + {dr2} = {dr6}");





        }
    }
}

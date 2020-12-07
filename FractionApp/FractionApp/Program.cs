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

            int x = 4;

            Fraction dr1 = new Fraction(8,8);

            //dr1.SetChisl(4);
            //dr1.SetZnam(5);

            dr1.ShowFraction();

            Fraction dr2 = new Fraction();

            dr2.SetChisl(7);
            dr2.SetZnam(9);

            dr2.ShowFraction();



            Fraction dr3 = new Fraction(5);
            dr3.ShowFraction();


            Fraction dr4 = new Fraction(3,6);
            dr4.Sokr();
            dr4.ShowFraction();


            dr4.Add(dr2);
            dr4.ShowFraction();


            var dr6 = Fraction.Add(dr4, dr2);
            dr6.ShowFraction();

            



        }
    }
}

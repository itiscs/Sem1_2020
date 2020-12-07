using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionApp
{
    class Fraction
    {
        private int chisl;
        private int znam;

        public Fraction()
        {
            chisl = 0;
            znam = 1;
        }

        public Fraction(int ch)
        {
            chisl = ch;
            znam = 1;
        }

        public Fraction(int ch, int zn)
        {
            if(zn == 0)
                throw new DivideByZeroException();

            chisl = ch;
            znam = zn;
            Sokr();
        }


        public void Sokr()
        {
            var n = Nod(chisl, znam);
            chisl /= n;
            znam /= n;

        }

        private int Nod(int a, int b)
        {
            while (b != 0)
                b = a % (a = b);
            return a;
        }

        public void SetChisl(int c)
        {
            chisl = c;
            Sokr();
        }

        public void SetZnam(int zn)
        {
            if (zn != 0)
                znam = zn;
            else
                throw new DivideByZeroException();
            Sokr();
        }

        public int GetZnam()
        {
            return znam;
        }
        public int GetChisl()
        {
            return chisl;
        }

        public void ShowFraction()
        {
            if (znam == 1)
                Console.WriteLine($"{chisl}");
            else
                Console.WriteLine($"{chisl}/{znam}");
        }

        //создание новой дроби A + B 
        public static Fraction Add(Fraction a, Fraction b)
        {
            var dr = new Fraction();
            dr.chisl = b.chisl * a.znam + b.znam * a.chisl;
            dr.znam = a.znam * b.znam;
            dr.Sokr();
            return dr;
        }


        //добавим параметр к this:   this = this + A 
        public void Add(Fraction a)
        {
            chisl = chisl * a.znam + znam * a.chisl;
            znam = znam * a.znam;
            Sokr();
        }






    }
}

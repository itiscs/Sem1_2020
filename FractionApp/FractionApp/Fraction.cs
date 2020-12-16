using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionApp
{
    public class Fraction
    {
        private int chisl;
        private int znam;

        public Fraction() : this(0,1) { }
        //{
        // chisl = 0;
        // znam = 1;
        //}

        public Fraction(int ch) : this(ch, 1) { }
        //{
        // chisl = ch;
        // znam = 1;
        //}

        //public Fraction(string ch) : this(int.Parse(ch), 1) { }

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
            if(znam < 0)
            {
                znam = -znam;
                chisl = -chisl;
            }
            var n = Nod(Math.Abs(chisl), Math.Abs(znam));
            chisl /= n;
            znam /= n;

        }

        private int Nod(int a, int b)
        {
            while (b != 0)
                b = a % (a = b);
            return a;
        }


        public int Chisl
        {
            get 
            {
                return chisl;
            }
            set
            {
                
                chisl = value;
                Sokr();
            }
        }

        public int Znam
        {
            get
            {
                return znam;
            }
            set
            {
                if (value != 0)
                    znam = value;
                else
                    throw new DivideByZeroException();
                Sokr();

            }
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

        public override string ToString()
        {
            if (znam == 1)
                return $"{chisl}";

            return $"{chisl}/{znam}";
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

        public static Fraction operator+(Fraction a, Fraction b)
        {
            var dr = new Fraction();
            dr.chisl = b.chisl * a.znam + b.znam * a.chisl;
            dr.znam = a.znam * b.znam;
            dr.Sokr();
            return dr;
        }

        public static Fraction operator-(Fraction a, Fraction b)
        {
            var dr = new Fraction();
            dr.chisl = a.chisl * b.znam - a.znam * b.chisl;
            dr.znam = a.znam * b.znam;
            dr.Sokr();
            return dr;
        }

        //добавим параметр к this:   this = this + A 
        public void Add(Fraction a)
        {
            chisl = chisl * a.Znam + znam * a.Chisl;
            znam = znam * a.znam;
            Sokr();
        }

        public bool GreaterThan(Fraction a)
        {
            throw new NotImplementedException();
        }
        public bool LessThan(Fraction a)
        {
            throw new NotImplementedException();
        }

        public static bool operator>(Fraction a, Fraction b)
        {
            return (a - b).Chisl > 0;            
        }

        public static bool operator <(Fraction a, Fraction b)
        {
            return !(a > b);
        }
        public static bool operator >=(Fraction a, Fraction b)
        {
            return (a - b).Chisl >= 0;
        }

        public static bool operator <=(Fraction a, Fraction b)
        {
            return !(a >= b);
        }

        public static bool operator ==(Fraction a, Fraction b)
        {
            return (a - b).Chisl == 0;
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            return !(a == b);
        }
        
        public static Fraction operator++ (Fraction a)
        {
            return new Fraction(a.Chisl+a.Znam,a.Znam);
        }

        public static bool operator false(Fraction a)
        {
            return a.Chisl == 0;
        }

        public static bool operator true(Fraction a)
        {
            return a.Chisl != 0;
        }

        public static implicit operator int(Fraction a)
        {
            return a.Chisl / a.Znam;
        }

        public static implicit operator Fraction(int a)
        {
            return new Fraction(a);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_struct_class
{
    abstract class Figur
    {
        protected const double P = 3.14;
        protected double AB, BC, CA, CD, DA;
        protected double Radius;
        protected double Hight;
        protected double Sq;
        protected double Per;
        public abstract double Squar();
        public abstract double Perimetr();
    }
    class Triangle : Figur
    {
        //private double AB, BC, CA;
        //private double Hight;
        //private double Sq;
        //private double Per;
        public Triangle()
        {
            AB = 3;
            BC = 4;
            CA = 5;
            Hight = 3.5;
        }
        public Triangle(double AB, double BC, double CA, double High)
        {
            this.AB = AB;
            this.BC = BC;
            this.CA = CA;
            Hight = High;
        }
        public override double Squar()
        {
            Sq = 0.5 * AB * Hight;
            return Sq;
        }
        public override double Perimetr()
        {
            Per = AB + BC + CA;
            return Per;
        }
        public override string ToString()
        {
            return $"This is Triangle: Perimetr-{Per}\tSquar-{Sq}";
        }
    }
    class Squar4 : Figur
    {
        public Squar4()
        {
            AB = BC = CD = DA = 0;
            //AB = CD;
            //BC = DA;
        }
        public Squar4(double AB)
        {
            this.AB = AB;
            this.AB = BC = CD = DA = AB;
        }
        public override double Squar()
        {
            Sq = AB * BC;
            return Sq;
        }
        public override double Perimetr()
        {
            Per = AB * 4;
            return Per;
        }
        public override string ToString()
        {
            return $"This is Square: Perimetr-{Per}\tSquar-{Sq}";
        }
    }
    class Rhombus : Figur
    {
        public Rhombus()
        {
            AB = CD;
            BC = DA;
        }
        public Rhombus(double AB, double BC, double Hight)
        {
            this.AB = CD = AB;
            this.BC = DA = BC;
            this.Hight = Hight;
        }
        public override double Squar()
        {
            Sq = AB * Hight;
            return Sq;
        }
        public override double Perimetr()
        {
            Per = (AB * 2) + (BC * 2);
            return Per;
        }
        public override string ToString()
        {
            return $"This is Rhombus: Perimetr-{Per}\tSquar-{Sq}";
        }
    }
    class Rectangl : Figur
    {
        public Rectangl()
        {
            AB = CD;
            BC = DA;
        }
        public Rectangl(double AB, double BC, double Hight)
        {
            this.AB = CD = AB;
            this.BC = DA = BC;
        }
        public override double Squar()
        {
            Sq = AB * BC;
            return Sq;
        }
        public override double Perimetr()
        {
            Per = (AB * 2) + (BC * 2);
            return Per;
        }
        public override string ToString()
        {
            return $"This is Rectangl: Perimetr-{Per}\tSquar-{Sq}";
        }
    }
    class Circle : Figur
    {
        public Circle()
        {
            Radius = 0;
        }
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public override double Squar()
        {
            Sq = P * (Radius * Radius);
            return Sq;

        }
        public override double Perimetr()
        {
            Per = 2 * P * Radius;
            return Per;
        }
        public override string ToString()
        {
            return $"This is Circle: Perimetr-{Per}\tSquar-{Sq}";
        }
    }
    class Elips : Figur
    {
        private double Radius1;
        private double Radius2;

        public Elips()
        {

        }
        public Elips(double R1, double R2)
        {
            Radius1 = R1;
            Radius2 = R2;
        }
        public override double Squar()
        {
            Sq = P * Radius1 * Radius2;
            return Sq;
        }
        public override double Perimetr()
        {
            Per = ((P * Radius1 * Radius2) + ((Radius1 - Radius2) * (Radius1 - Radius2))) / ((Radius1 * 2) + (Radius2 * 2));
            Per *= 4;
            return Per;
        }
        public override string ToString()
        {
            return $"This is Elips: Perimetr-{Per}\tSquar-{Sq}";
        }
    }
    class Some_Figure
    {
        private int Size = 6;
        private Figur[] Some_F = new Figur[6];
        private double Perimetr;
        private double Squar;

        public Some_Figure()
        {
            Perimetr = 0;
            Squar = 0;
            Some_F[0] = new Elips(3.15, 4.12);
            Some_F[1] = new Circle(5.45);
            Some_F[2] = new Rectangl(3.46, 4.55, 2.55);
            Some_F[3] = new Rhombus(4.4,5.5,1.5);
            Some_F[4] = new Squar4(5);
            Some_F[5] = new Triangle();
        }
        public void Sum_all_Perimetr()
        {
            for(int i=0;i<Size;i++)
            {
                Perimetr += Some_F[i].Perimetr();
            }
        }
        public void Sum_all_Square()
        {
            for (int i = 0; i < Size; i++)
            {
                Squar += Some_F[i].Squar();
            }
        }
        public void Show_All()
        {
            
            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine(Some_F[i].ToString());
                Console.WriteLine("__________");
            }
        }
        public override string ToString()
        {
            return $"All figur Perimetr-{Perimetr}\tSquar-{Squar}";
        }
    }

}

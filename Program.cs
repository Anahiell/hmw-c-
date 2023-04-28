using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegator
{
    public delegate void Delegator(string Some_string);
    public delegate string DelegatorArif(double X, double Y);
    public delegate bool Preicator<in T>(T obj);
    class Arif
    {

        public string Plus(double X, double Y)
        {
            return $"{X}+{Y}={X + Y}";
        }
        public string Minus(double X, double Y)
        {
            return $"{X}-{Y}={X - Y}";
        }
        public string Multi(double X, double Y)
        {
            return $"{X}*{Y}={X * Y}";
        }
    }
    class Program
    {
        public static void Massage(string Some_Mas)
        {
            Console.WriteLine(Some_Mas);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Task #1\nEnter the massage:");
            string ClientMassage;
            ClientMassage = Console.ReadLine();
            Console.WriteLine("Call delegator!!!");
            Delegator Del = new Delegator(Massage);
            Del(ClientMassage);
            Del.Invoke(ClientMassage);
            Console.WriteLine("Task #2");
            Arif Ar = new Arif();
            DelegatorArif[] Darif = { Ar.Plus, Ar.Minus, Ar.Multi };
            foreach (var S in Darif)
            {
                Console.WriteLine(S.Invoke(2, 3));
            }
            Console.WriteLine("Task #3");
            Preicator<double> PrePar = (double x) => (x % 2) == 0;
            Console.WriteLine("2 is pair? -" + PrePar(2));
            Console.WriteLine("3 is pair? -" + PrePar(3));
            PrePar = (double x) => ((x % 2) != 0) && (x / 1 == x) && (x / x == 1);
            Console.WriteLine("3 is nature? -" + PrePar(3));
            Console.WriteLine("6 is nature? -" + PrePar(6));
            int Fibonachi(double n)
            {
                if (n == 0 || n == 1) return (int)n;

                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }

            PrePar = (double x) => x == Fibonachi(x);
            Console.WriteLine("4 is Fibonachi num? -" + PrePar(4));
            Console.WriteLine("5 is Fibonachi num? -" + PrePar(5));

        }
    }
}

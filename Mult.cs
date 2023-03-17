using System;

namespace HMW
{
    internal class Mult
    {
        private int X;
        public Mult(int x)
        {
            if (x >= 1 && x <= 100)
            {
                X = x;
            }
            else
            {
                Console.WriteLine("Wrong number");
            }
        }
        public void Fizz_Buzz()
        {
            if ((X % 3 == 0) && (X % 5 == 0))
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if (X % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (X % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine("Dont have multiplicity: " + X);
            }
        }
    }
      internal  class Date
        {
            private int D;
            private int M;
            private int Y;
             public Date(int D,int M,int Y)
            {
                this.D = D;
                this.M = M;
                this.Y = Y;
            }
            public void Month()
            {
                if(M==12||M==1||M==2)
                {
                    Console.WriteLine(D + "." + M + "." + Y + " Winter");
                }
                if (M == 3 || M == 4 || M == 5)
                {
                    Console.WriteLine(D + "." + M + "." + Y + " Spring");
                }
                if (M == 6 || M == 7 || M == 8)
                {
                    Console.WriteLine(D + "." + M + "." + Y + " Summer");
                }
                if (M == 9 || M == 10 || M == 11)
                {
                    Console.WriteLine(D+"."+M+"."+Y+" Autum");
                }
            }

        }
        
    
}

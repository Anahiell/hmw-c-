using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMW
{
 
    class Program
    {
        
        static void Main(string[] args)
        {
            int var;
            Console.WriteLine("\tWelcome\nChouse Task(1-7)");
            var = Int32.Parse(Console.ReadLine());
            while (var != 0)
            {
                switch (var)
                {
                    case 1://task Multiplicity
                        {
                            Console.WriteLine("Write number (1-100)");
                            int x = Int32.Parse(Console.ReadLine());
                            Mult mul = new Mult(x);
                            mul.Fizz_Buzz();
                            break;
                        }
                    case 2://task Pircent 
                        {
                            Console.WriteLine("Write number:");
                            int x = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Write percent:");
                            int y = Int32.Parse(Console.ReadLine());
                            double res = (x * ((double)y / 100));
                            Console.WriteLine("Pircent: " + res+"%");
                            break;
                        }
                    case 3:// task creat number
                        {
                            Console.WriteLine("Start creat number:");
                            Console.WriteLine("Write number THOUSANDTHS:");
                            int x = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Write number HUNDREDTHS:");
                            int y = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Write number DOZEN:");
                            int z = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Write number UNITS:");
                            int e = Int32.Parse(Console.ReadLine());
                            int res = ((x * 1000) + (y * 100) + (z * 10) + (e * 1));
                            Console.WriteLine("Your number is: " + res);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("You have some numbe, you can SWAP him 3tims");
                            int[] Ar=new int[6];
                            for(int i=0;i<6;i++)
                            {
                                Ar[i] = i;
                            }
                            int x;
                            int Count=0;
                            for (int i = 0; i < 6; i++)
                            {
                                Console.Write(Ar[i] + ";");
                            }
                            while (Count!=3)
                            { 
                                Console.WriteLine("Enter two number to change");
                                int ind1 = Int32.Parse(Console.ReadLine());
                                int ind2 = Int32.Parse(Console.ReadLine());
                                x = Ar[ind1];
                                Ar[ind1] = Ar[ind2];
                                Ar[ind2] = x;
                                Console.WriteLine("SWAP!!!");
                                for (int i = 0; i < 6; i++)
                                {
                                    Console.Write(Ar[i] + ";");
                                }
                                Count++;
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Write number:");
                            int x = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Write number:");
                            int y = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Write number:");
                            int z = Int32.Parse(Console.ReadLine());
                            Date d = new Date(x, y, z);
                            d.Month();
                            break;
                        }
                    case 6://Far and Cel
                        {
                            //(2 °C × 9 / 5) +32 = 35,6 °F


                            Console.WriteLine("Enter the number Celsius or Faraday");
                                float x = float.Parse(Console.ReadLine());
                            float resF = ((x * (9 / 5) + 32));
                            float resC = (x - 32) * (5 / 9);
                            Console.WriteLine("Celsius: " + resC + "\nFaraday: " + resF);
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Enter two number:");
                            int x = Int32.Parse(Console.ReadLine());
                            int y = Int32.Parse(Console.ReadLine());
                            if(x<y)
                            {
                                Console.WriteLine("Double number:");
                                do
                                {
                                    if (x % 2 == 0)
                                        Console.WriteLine(x);
                                    x++;
                                }
                                while (x <= y);
                            }
                            else
                            {
                                Console.WriteLine("Double number:");
                                do
                                {
                                    if (y % 2 == 0)
                                        Console.WriteLine(y);
                                    y++;
                                }
                                while (y <= x);
                            }

                            break;
                        }
                    default:
                        break;
                }
                Console.WriteLine("\nChouse Task(1-7)");
                var = Int32.Parse(Console.ReadLine());
            }
        }
    }
}
